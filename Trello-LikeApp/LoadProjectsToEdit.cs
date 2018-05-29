﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Trello_LikeApp
{
    class LoadProjectsToEdit
    {
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private CheckedListBox editProjectsChckBox;



        public LoadProjectsToEdit(Label label11, 
            CheckedListBox editProjectsChckBox, 
            Label label12, Label label13, 
            Label label14, Label label15)
        {
            this.label11 = label11;
            this.editProjectsChckBox = editProjectsChckBox;
            this.label12 = label12;
            this.label13 = label13;
            this.label14 = label14;
            this.label15 = label15;
        }

        public void LoadThings()
        {
            try
            {
                if (!File.Exists(editProjectsChckBox.Text))
                {
                    MessageBox.Show("Error.");
                }
                else
                {
                    StreamReader reader = new StreamReader(editProjectsChckBox.Text);
                    label11.Text = reader.ReadLine();
                    label12.Text = reader.ReadLine();
                    label14.Text = reader.ReadLine();
                    label13.Text = reader.ReadLine();
                    label15.Text = reader.ReadLine();
                    reader.Close();
                }
            }
            catch (PathTooLongException e) { MessageBox.Show(e.Message); }
            catch (FileNotFoundException e) { MessageBox.Show(e.Message); }
            catch (IOException e) { MessageBox.Show(e.Message); }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }
    }
}
