﻿using Accord;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Filters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IntSys03_ID3_AccordFW
{
    public partial class Form1 : Form
    {
        public string trainingPath;
        public string inputPath;
        public string outputPath;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Working...";

            // load training data
            DataTable dtDataTraining = CSVtoDataTable(trainingPath);

            string answerAttribute = dtDataTraining.Columns[dtDataTraining.Columns.Count - 1].ToString();   // "Buy" in this example

            // Create a new codification codebook to convert strings into integer symbols
            var codebook = new Codification(dtDataTraining);

            // translate our training data into integer symbols using our codebook:
            DataTable symbols = codebook.Apply(dtDataTraining);

            // create attributes string array
            string[] attributes = new string[dtDataTraining.Columns.Count - 1];
            for(int i = 0; i < attributes.Length; i++)
            {
                attributes[i] = dtDataTraining.Columns[i].ToString();
            }

            // define inputs and outputs
            int[][] inputs = symbols.ToArray<int>(attributes);
            int[] outputs = symbols.ToArray<int>(dtDataTraining.Columns[dtDataTraining.Columns.Count - 1].ToString());

            
            // create ID3
            var id3learning = new ID3Learning();
            
            // learn from examples
            DecisionTree tree = id3learning.Learn(inputs, outputs);

            // Compute the training error when predicting training instances
            //double error = new ZeroOneLoss(outputs).Loss(tree.Decide(inputs));


            // load data to process
            DataTable dtData = CSVtoDataTable(inputPath);

            List<string> allAnswers = new List<string>();   // define list of answers
            
            // iterate table rows as queries
            for (int j = 0; j < dtData.Rows.Count; j++)
            {
                // create query string
                string[,] strQuery = new string[dtData.Columns.Count, 2];
                for (int i = 0; i < dtData.Columns.Count; i++)
                {
                    strQuery[i, 0] = dtData.Columns[i].ToString();
                    strQuery[i, 1] = dtData.Rows[j].ItemArray[i].ToString();
                }

                // turn query to int
                int[] query = codebook.Transform(strQuery);

                // get answer as codebook int
                int predicted = tree.Decide(query);

                // translate back from codebook
                allAnswers.Add(codebook.Revert(answerAttribute, predicted));
            }


            // append allAnswers to dtData table as last column
            dtData.Columns.Add(answerAttribute);
            for(int i = 0; i < dtData.Rows.Count; i++)
            {
                dtData.Rows[i][answerAttribute] = allAnswers[i];
            }

            DataTableToCSV(dtData, outputPath);     // save

            lblStatus.Text = "Done! Check output file.";
        }

        public void DisplayTable(DataTable dt)
        {
            foreach(var name in dt.Columns)
            {
                Debug.Write(name + "\t\t\t");
            }

            Debug.WriteLine("");

            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Debug.Write(item + "\t\t\t\t");
                }
                Debug.WriteLine("");
            }
        }

        public static DataTable CSVtoDataTable(string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);
            string[] headers = sr.ReadLine().Split(',');
            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }
            while (!sr.EndOfStream)
            {
                string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                DataRow dr = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static void DataTableToCSV(DataTable dtDataTable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            //headers  
            for (int i = 0; i < dtDataTable.Columns.Count; i++)
            {
                sw.Write(dtDataTable.Columns[i]);
                if (i < dtDataTable.Columns.Count - 1)
                {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            foreach (DataRow dr in dtDataTable.Rows)
            {
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        }
                        else
                        {
                            sw.Write(dr[i].ToString());
                        }
                    }
                    if (i < dtDataTable.Columns.Count - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
        }

        private void btnTrainingPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv;|All files (*.*)|*.*";
            ofd.ShowDialog();
            trainingPath = ofd.FileName;

            tboxTrainingPath.Text = trainingPath;
        }

        private void btnDataPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv;|All files (*.*)|*.*";
            ofd.ShowDialog();
            inputPath = ofd.FileName;

            tboxInputPath.Text = inputPath;
        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV file (.csv)|*.csv|All files (*.*)|*.*";
            sfd.ShowDialog();
            outputPath = sfd.FileName;

            tboxOutputPath.Text = outputPath;
        }
    }
}
