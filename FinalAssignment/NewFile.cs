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

    /// <summary>
    /// Class that has a text editor with the line numbers where the code is written
    /// this form's class has a a menutoolstrip and in there is a run button which when pressed 
    /// executes the code that is typed in the text editor there are 2 custom methods which checks the parameters that 
    /// is passed for the shapes to be drawn
    /// </summary>
public partial class NewFile : Form
{
        //variable declaration 
        int repeatValue;
        string[] param;

        //default constructor
        public NewFile()
    {
        InitializeComponent();
    }



        ///<summary>
        ///method that is used to load the form which takes two parameters
        ///</summary>
        ///<param name="sender"></param>
        ///<param name="e"></param>
        private void NewFile_Load(object sender, EventArgs e)
    {

    }

        /// <summary>
        /// texteditor method whic is used to load the text editor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textEditorControl1_Load(object sender, EventArgs e)
    {
      

    }

        /// <summary>
        /// a methos that belongs to the menustrip which contains the dropdown
        /// run. when pressing the command in the text editor gets executed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    private void runToolStripMenuItem_Click(object sender, EventArgs e)
    {
        //variable declarations
        String command = textEditorControl1.Text;
        string[] syntax = command.Split(' ');

            //check if the first string in the editor is draw
        if (syntax[0].Equals("draw"))
        {
                //exception handling
                try
                {
                    //use of Split function
                   param = syntax[2].Split(',');

                    //check if the second string in the editor is shape name i.e. rectangle
                    if (syntax[1].Equals("rectangle"))
                    {
                        //if there is problem with the parameter the message is shown
                        if(checkParam(param,"rectangle") == false)
                        {
                            MessageBox.Show("Parameters Not Enough");
                        }

                        if(checkParamValue(param) == true)
                        {
                            MessageBox.Show("Parameters Not Valid");
                        }

                        try
                        {
                            //convert the splitted parameters to int from string
                            int p1 = Convert.ToInt32(param[0]);
                            int p2 = Convert.ToInt32(param[1]);
                            int p3 = Convert.ToInt32(param[2]);
                            int p4 = Convert.ToInt32(param[3]);
                            
                            //shapefactory class object
                            ShapeFactory shapeFactory = new ShapeFactory();
                            Shape shape1 = shapeFactory.GetShape("rectangle");
                            //call the draw method in getshape method
                            shape1.draw(p1, p2, p3, p4,0,0,0,0,0,0);                     

                            
                        }
                        catch (Exception)
                        {
                            
                        }
                    }

                    //checks if the first word in the texteditor is circle
                   else if (syntax[1].Equals("circle"))
                    {
                        if (checkParam(param, "circle") == false)
                        {
                            MessageBox.Show("Parameters Not Enough");
                        }

                        if (checkParamValue(param) == true)
                        {
                            MessageBox.Show("Parameters Not Valid");
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
                            shape2.draw(p1, p2, p3, p4,0,0,0,0,0,0);


                        }
                        catch (Exception)
                        {

                        }
                    }

                    else if (syntax[1].Equals("triangle"))
                    {
                        if (checkParam(param, "triangle") == false)
                        {
                            MessageBox.Show("Parameters Not Enough");
                        }

                        if (checkParamValue(param) == true)
                        {
                            MessageBox.Show("Parameters Not Valid");
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
                            shape3.draw(p1, p2, p3, p4,p5,p6,0,0,0,0);


                        }
                        catch (Exception)
                        {

                        }
                    }

                    else if (syntax[1].Equals("polygon"))
                    {
                        if (checkParam(param, "polygon") == false)
                        {
                            MessageBox.Show("Parameters Not Enough");
                        }

                        if (checkParamValue(param) == true)
                        {
                            MessageBox.Show("Parameters Not Valid");
                        }

                        try
                        {
                            int p1 = Convert.ToInt32(param[0]);
                            int p2 = Convert.ToInt32(param[1]);
                            int p3 = Convert.ToInt32(param[2]);
                            int p4 = Convert.ToInt32(param[3]);
                            int p5 = Convert.ToInt32(param[4]);
                            int p6 = Convert.ToInt32(param[5]);
                            int p7 = Convert.ToInt32(param[6]);
                            int p8 = Convert.ToInt32(param[7]);
                            int p9 = Convert.ToInt32(param[8]);
                            int p10 = Convert.ToInt32(param[9]);

                            // MessageBox.Show("Draw rectangle with parameter" + parameter1 + "and" + parameter2);

                            ShapeFactory shapeFactory = new ShapeFactory();
                            Shape shape7 = shapeFactory.GetShape("polygon");
                            shape7.draw(p1, p2, p3, p4, p5, p6,p7,p8,p9,p10);


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
            } 





            if (syntax[0].Equals("repeat"))
            {
                try
                {
                    repeatValue = Convert.ToInt32(syntax[1]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Loop Value Incorrect");
                }
                try
                { 

                    if (syntax[2].Equals("rectangle"))
                    {                     
                        
                        string operatorValue = syntax[3];

                        if(operatorValue != "+" && operatorValue != "-")
                        {
                            MessageBox.Show("Operator Sign Incorrect");
                        }
                       
                        try
                        {
                            int increaseValue = Convert.ToInt32(syntax[4]);

                          ShapeFactory shapeFactory = new ShapeFactory();
                          Shape shape4 = shapeFactory.GetShape("rectangle");
                          shape4.repeatParam(repeatValue, operatorValue, increaseValue);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Integer Value Incorrect");
                        }
                    }



                    else if (syntax[2].Equals("circle"))
                    {

                        string operatorValue = syntax[3];

                        if (operatorValue != "+" && operatorValue != "-")
                        {
                            MessageBox.Show("Operator Sign Incorrect");
                        }

                        try
                        {
                            int increaseValue = Convert.ToInt32(syntax[4]);

                            ShapeFactory shapeFactory = new ShapeFactory();
                            Shape shape5 = shapeFactory.GetShape("circle");
                            shape5.repeatParam(repeatValue, operatorValue, increaseValue);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Integer Value Incorrect");
                        }
                    }




                    else if (syntax[2].Equals("triangle"))
                    {

                        string operatorValue = syntax[3];

                        if (operatorValue != "+" && operatorValue != "-")
                        {
                            MessageBox.Show("Operator Sign Incorrect");
                        }

                        try
                        {
                            int increaseValue = Convert.ToInt32(syntax[4]);

                            ShapeFactory shapeFactory = new ShapeFactory();
                            Shape shape6 = shapeFactory.GetShape("triangle");
                            shape6.repeatParam(repeatValue, operatorValue, increaseValue);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Integer Value Incorrect");
                        }
                    }

                    else if (syntax[2].Equals("polygon"))
                    {

                        /*for(int i = 0; i < syntax.Length; i++)
                        {
                            MessageBox.Show(syntax[i]);
                        }*/

                      
                        string operatorValue = syntax[3];

                        if (operatorValue != "+" && operatorValue != "-")
                        {
                            MessageBox.Show("Operator Sign Incorrect");
                        }

                        try
                        {
                            int increaseValue = Convert.ToInt32(syntax[4]);

                            ShapeFactory shapeFactory = new ShapeFactory();
                            Shape shape77 = shapeFactory.GetShape("polygon");
                            shape77.repeatParam(repeatValue, operatorValue, increaseValue);

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Integer Value Incorrect");
                        }
                    }





                    else
                    {
                        MessageBox.Show("Invalid Repeat Command!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid Repeat Command Executed");
                }
            }


            //check if the first string in the texteditor is var
            if (syntax[0].Equals("var"))
            {
                string[] param; 

                int counterValue = Convert.ToInt32(syntax[3]);

                string shapeValue = syntax[5];

                int counterCheckValue = Convert.ToInt32(syntax[10]);

                if(counterValue != counterCheckValue)
                {
                    MessageBox.Show("Counter value isnot equal to: " + counterCheckValue);
                }

                if(shapeValue == "rectangle")
                {
                    param = syntax[6].Split(',');

                    int a = Convert.ToInt32(param[0]);
                    int b = Convert.ToInt32(param[1]);
                    int c = Convert.ToInt32(param[2]);
                    int d = Convert.ToInt32(param[3]);

                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape shape11 = shapeFactory.GetShape("rectangle");
                    shape11.ifParam(a, b, c, d,0,0, counterValue);

                }

                else if (shapeValue == "circle")
                {
                    param = syntax[6].Split(',');

                    int a = Convert.ToInt32(param[0]);
                    int b = Convert.ToInt32(param[1]);
                    int c = Convert.ToInt32(param[2]);
                    int d = Convert.ToInt32(param[3]);

                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape shape12 = shapeFactory.GetShape("circle");
                    shape12.ifParam(a, b, c, d,0,0, counterValue);

                }

                else if(shapeValue == "triangle")
                {
                    param = syntax[6].Split(',');
                    int a = Convert.ToInt32(param[0]);
                    int b = Convert.ToInt32(param[1]);
                    int c = Convert.ToInt32(param[2]);
                    int d = Convert.ToInt32(param[3]);
                    int ce = Convert.ToInt32(param[4]);
                    int f = Convert.ToInt32(param[5]);

                    ShapeFactory shapeFactory = new ShapeFactory();
                    Shape shape13 = shapeFactory.GetShape("triangle");
                    shape13.ifParam(a, b, c, d,ce,f ,counterValue);

                }
                

            /*for(int i = 0; i < syntax.Length; i++)
                {
                    MessageBox.Show(syntax[i]);
                }*/



            }
           




    }


        /// <summary>
        /// method that returns true/false when parameters are passed to check
        /// </summary>
        /// <param name="param"></param>
        /// <param name="value"></param>
        /// <returns></returns>

        public Boolean checkParam(string[] param,string value)
        {
            if(param.Length == 4 && value == "rectangle")
            {
                return true;
            }

            else if (param.Length == 4 && value == "circle")
            {
                return true;
            }

            else if (param.Length == 6 && value == "triangle")
            {
                return true;
            }

            else if (param.Length == 10 && value == "polygon")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// method that returns true/false when passing string array to check
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public Boolean checkParamValue(string[] param)
        {
            int[] values = new int[50];
            bool count = false;

            for(int i = 0; i < param.Length; i++)
            {
                try
                {
                    values[i] = Convert.ToInt32(param[i]);
                }
                catch (Exception)
                {
                    count = true;
                }
                
            }

            return count;
        }


        /// <summary>
        /// texteditorcontrol method that is used for syntax highlighting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// method to take the read text file from the first form
        /// to the text editor in the current form
        /// </summary>
        /// <param name="abc"></param>
        public void copyText(string abc)
        {
            textEditorControl1.Text = abc;
        }

        /// <summary>
        /// method that runs the save function when pressed. a dialog box opens
        /// ans we can save the text in the texteditor as a text file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
           
       
