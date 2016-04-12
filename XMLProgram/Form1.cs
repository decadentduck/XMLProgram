using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XMLProgram
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            /* READ FROM XML FILE
            * 
            * The following code will open an XML file and read
            * it one line at a time, while also displaying it to
            * the console screen
            */

            // Open the file to be read
            XmlTextReader reader = new XmlTextReader("information.xml");

            // Clear output label
            outputLabel.Text = "";

            // Continue to read each element and text until the file is done
            while (reader.Read())  
            {
                // If the currently read item is text then print it to screen,
                // otherwise the loop repeats getting the next piece of information
                if (reader.NodeType == XmlNodeType.Text)
                {
                    outputLabel.Text += reader.Value + "\n";
                }
            }
            // When done reading the file close it
            reader.Close();

        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            /* WRITE TO XML FILE
            * 
            * The following code will create a new XML file and 
            * then create element headers and content.  Finally it 
            * saves the info to the XML file.  If a file already exists
            * with the same name it will be overwritten with the 
            * information below.
            */

            XmlTextWriter writer = new XmlTextWriter("outputExample.xml", null);

            //Write the "Class" element
            writer.WriteStartElement("Class");

            //Start "student" element
            writer.WriteStartElement("student");

            //Write sub-elements
            writer.WriteElementString("name", "Chris");
            writer.WriteElementString("address", "1313 Mockingbird Lane");
            writer.WriteElementString("phone", "555-1313");
            writer.WriteElementString("sex", "Female");

            // end the "student" element
            writer.WriteEndElement();

            // end the "Class" element
            writer.WriteEndElement();

            //Write the XML to file and close the writer
            writer.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            /* The following code will open an XML file and search 
            * for a specific node.  When it finds the node it will
            * then search for specific content. If found it will 
            * replace that content with new info.
            */

            //open XML document
            XmlDocument doc = new XmlDocument();
            doc.Load("information.xml");

            //create a node variable to represent an element
            XmlNode node;

            node = doc.DocumentElement;

            //node1 is a child of node and node2 is a child of node1
            //The name sub element is searched and if the text matches 'Chris'
            //it is changed to 'Howard'
            foreach (XmlNode node1 in node.ChildNodes)
                foreach (XmlNode node2 in node1.ChildNodes)
                    //if (node2.Name == "name" && node2.InnerText == "Chris")
                    //{
                    //    node2.InnerText = "Howard";
                    //}
                    if (node2.Name == nodeSelect.Text && node2.InnerText == contentSelect.Text)
                    {
                        node2.InnerText = newContent.Text;
                    }
            //save and close the document
            doc.Save("information.xml");

            readButton_Click(sender, e);
        }
    }
}
