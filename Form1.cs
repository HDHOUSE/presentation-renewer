using Microsoft.Office.Interop.PowerPoint;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.Office.Core;
using System.Linq;
using System.Drawing;

namespace presentation_renewer
{
    public partial class Form1 : Form
    {
        string pathPresentation, pathBackground;

        Microsoft.Office.Interop.PowerPoint.Application presentationApp = new Microsoft.Office.Interop.PowerPoint.Application();


        public Form1()
        {
            InitializeComponent();
        }



        private void buttonSelectPresentation_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            openFileDialog1.Filter = "Presentation (.pptx ,.ppt)|*.pptx;*.ppt";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pathPresentation = openFileDialog1.FileName;
                textBox_presentationPath.Text = pathPresentation;


            }
        }



        private void buttonSelectBackground_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.SpecialFolder.Desktop.ToString();
            openFileDialog1.Filter = "\"Image Files|*.jpg;*.jpeg;*.png;*.gif;...\";";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //todo добавить проверку размера
                pathBackground = openFileDialog1.FileName;
                textBox_pathBackground.Text = pathBackground;


            }
        }


        private void button_start_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            if (pathPresentation != null && pathPresentation != null)
            {
                List<string> textList = new List<string> { };
                int oldSlidesCount = 0;


                  getTextPresentation(pathPresentation, ref textList, ref oldSlidesCount);
                progressBar1.Value = 40;
                System.Console.WriteLine(oldSlidesCount);
/*
                foreach (string textSlide in textList)
                {
                    System.Console.WriteLine(textSlide);
                }

*/

                string  pathNewPresentation = createNewPathPresentation(pathPresentation);
                progressBar1.Value = 50;
                createNewPresentation(pathNewPresentation, pathBackground, ref textList);

                progressBar1.Value = 100;
                progressBar1.Value = 0;

            }
            else
            {
                MessageBox.Show(
                "Не заполнены важные поля!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
               );
            }
        }

        private void getTextPresentation(string pathPresentation, ref List<string> textList, ref int slidesCount)
        {
            Presentation presentation = presentationApp.Presentations.Open(pathPresentation,
                MsoTriState.msoFalse,
                MsoTriState.msoFalse,
                MsoTriState.msoFalse);

            slidesCount = presentation.Slides.Count;

            foreach (Slide slide in presentation.Slides)
            {
                foreach (Microsoft.Office.Interop.PowerPoint.Shape shape in slide.Shapes)
                {
                    if (shape.HasTextFrame == MsoTriState.msoTrue)
                    {
                        var textFrame = shape.TextFrame;
                        if (textFrame.HasText == MsoTriState.msoTrue)
                        {
                            string textRange = textFrame.TextRange.Text;
                            textRange = Regex.Replace(textRange, @"\s+", " ");

                            textList.Add(textRange);
                        }
                        else {
                            textList.Add("");
                        }
                    }

                }
            }

            presentation.Close();
        }

        private string createNewPathPresentation(string pathPresentation)
        {
            string[] pathArray = pathPresentation.Split('\\');

            pathArray[pathArray.Length - 1] = pathArray.Last().Substring(0, pathArray.Last().IndexOf('.'));
            pathArray[pathArray.Length - 1] = Regex.Match(pathArray.Last(), @"[\D\s]*").Value;
            pathArray[pathArray.Length - 1] += DateTime.Today.Year.ToString() + ".pptx";


            for (int i = 0; i < pathArray.Length -1; i++)
            {
                pathArray[i] +=  '\\';
            }

            return string.Concat(pathArray); 
        }

        private void createNewPresentation( string pathNewPresentation, string pathPicture, ref List<string> textList)
        {
           
            Slides slides;
            _Slide slide;
            TextRange objText;

            // Create the Presentation File
            Presentation pptPresentation = presentationApp.Presentations.Add(MsoTriState.msoTrue);

            CustomLayout pictureLayout = pptPresentation.SlideMaster.CustomLayouts[1];
            CustomLayout textLayout = pptPresentation.SlideMaster.CustomLayouts[6];


            // Create new Slide
            slides = pptPresentation.Slides;
            slide = slides.AddSlide(1, pictureLayout);

            Microsoft.Office.Interop.PowerPoint.Shape shape = slide.Shapes[1];
            slide.Shapes.AddPicture(pathPicture, MsoTriState.msoFalse, MsoTriState.msoTrue, 0, 0, 960, 540);

            int slideWithText = 2;
            foreach (string text in textList) {
                slide = slides.AddSlide(slideWithText, textLayout);

                // Add title
                Microsoft.Office.Interop.PowerPoint.Shape shape2 = slide.Shapes[1];
                objText = slide.Shapes[1].TextFrame.TextRange;
                objText.Text = text;
                objText.Font.Name = "NEXT ART";
                objText.Font.Size = 44;
                objText.Font.Bold = MsoTriState.msoTrue;
                objText.Font.Color.RGB = BGR(Color.White);
                objText.Font.Shadow = MsoTriState.msoTrue;
                objText.ParagraphFormat.Alignment = PpParagraphAlignment.ppAlignCenter;


                Microsoft.Office.Interop.PowerPoint.Shape shape3 = slide.Shapes[1];
                slide.Shapes.AddPicture(pathPicture, MsoTriState.msoFalse, MsoTriState.msoTrue, 0, 0, 960, 540).ZOrder(MsoZOrderCmd.msoSendToBack);

                     slideWithText++;


            }

            slide = slides.AddSlide(slideWithText, pictureLayout);

            Microsoft.Office.Interop.PowerPoint.Shape shape4 = slide.Shapes[1];
            slide.Shapes.AddPicture(pathPicture, MsoTriState.msoFalse, MsoTriState.msoTrue, 0, 0, 960, 540);

            pptPresentation.SaveAs(pathNewPresentation, PpSaveAsFileType.ppSaveAsDefault, MsoTriState.msoTrue);
            //pptPresentation.Close();
            //pptApplication.Quit();
        }

        private int BGR(Color color)
        {

            // PowerPoint's color codes seem to be reversed (i.e., BGR) not RGB, so we have  to  produce the color in reverse

            int iColor = (color.A << 24) | (color.B << 16) | (color.G << 8) | color.R;
            return iColor;
        }
    }

}
