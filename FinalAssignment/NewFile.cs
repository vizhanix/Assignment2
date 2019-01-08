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
        string dric = Application.StartupPath;
        FileSyntaxModeProvider fsmp;
        if (Directory.Exists(dric))
        {
            fsmp = new FileSyntaxModeProvider(dric);
            HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
            textEditorControl1.SetHighlighting("C#");
        }

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
                            // MessageBox.Show("Draw rectangle with parameter" + parameter1 + "and" + parameter2);

                            ShapeFactory shapeFactory = new ShapeFactory();
                            Shape shape2 = shapeFactory.GetShape("rectangle");
                            shape2.draw(p1, p2, p3, p4);                     

                            
                        }
                        catch (Exception)
                        {
                           
                        }
                    }
              
                    else
                    {
                        MessageBox.Show("Invalid Command Executed");
                    }


                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Draw Command Executed");
                }
            } else
                {
                MessageBox.Show("Invalid Commands Executed outer");
            }
        }
    }
}
           
       
