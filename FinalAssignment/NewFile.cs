using ICSharpCode.TextEditor.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAssignment
{
public partial class NewFile : Form
{
    public NewFile()
    {
        InitializeComponent();
    }

    private void NewFile_Load(object sender, EventArgs e)
    {

    }

    private void textEditorControl1_Load(object sender, EventArgs e)
    {
      

    }

    private void runToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //draw rectangle 20,20
        String command = textEditorControl1.Text;
        string[] syntax = command.Split(' ');

        if (syntax[0].Equals("draw"))
        {
                try
                {
                    string[] param = syntax[2].Split(',');

                    if (syntax[1].Equals("rectangle"))
                    {
                        if(param.Length != 4)
                        {
                            MessageBox.Show("Parameters Not Enough");
                        }
                        try
                        {
                            int p1 = Convert.ToInt32(param[0]);
                            int p2 = Convert.ToInt32(param[1]);
                            int p3 = Convert.ToInt32(param[2]);
                            int p4 = Convert.ToInt32(param[3]);
                            
                            ShapeFactory shapeFactory = new ShapeFactory();
                            Shape shape1 = shapeFactory.GetShape("rectangle");
                            shape1.draw(p1, p2, p3, p4,0,0);                     

                            
                        }
                        catch (Exception)
                        {
                            
                        }
                    }

                   else if (syntax[1].Equals("circle"))
                    {
                        if (param.Length != 4)
                        {
                            MessageBox.Show("Parameters Not Enough");
                        }
                        try
                        {
                            int p1 = Convert.ToInt32(param[0]);
                            int p2 = Convert.ToInt32(param[1]);
                            int p3 = Convert.ToInt32(param[2]);
                            int p4 = Convert.ToInt32(param[3]);

                            // MessageBox.Show("Draw rectangle with parameter" + parameter1 + "and" + parameter2);

                            ShapeFactory shapeFactory = new ShapeFactory();
                            Shape shape2 = shapeFactory.GetShape("circle");
                            shape2.draw(p1, p2, p3, p4,0,0);


                        }
                        catch (Exception)
                        {

                        }
                    }

                    else if (syntax[1].Equals("triangle"))
                    {
                        if (param.Length != 6)
                        {
                            MessageBox.Show("Parameters Not Enough");
                        }
                        try
                        {
                            int p1 = Convert.ToInt32(param[0]);
                            int p2 = Convert.ToInt32(param[1]);
                            int p3 = Convert.ToInt32(param[2]);
                            int p4 = Convert.ToInt32(param[3]);
                            int p5 = Convert.ToInt32(param[4]);
                            int p6 = Convert.ToInt32(param[5]);

                            // MessageBox.Show("Draw rectangle with parameter" + parameter1 + "and" + parameter2);

                            ShapeFactory shapeFactory = new ShapeFactory();                            
                            Shape shape3 = shapeFactory.GetShape("triangle");                            
                            shape3.draw(p1, p2, p3, p4,p5,p6);


                        }
                        catch (Exception)
                        {

                        }
                    }



                    else
                    {

                        MessageBox.Show("Invalid Graphics Command!");

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Draw Command Executed");
                }
            } else
                {
                MessageBox.Show("No Such Command, Please Try Again!!!");
            }
        }

        private void textEditorControl1_Load_1(object sender, EventArgs e)
        {
            string dric = Application.StartupPath;
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(dric))
            {
                fsmp = new FileSyntaxModeProvider(dric);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                textEditorControl1.SetHighlighting("C#");
            }

        }

        public void copyText(string abc)
        {
            textEditorControl1.Text = abc;
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog()== DialogResult.OK)
            {
                using (Stream s = File.Open(save.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(textEditorControl1.Text);
                }
            }
        }
    }
}
           
       
