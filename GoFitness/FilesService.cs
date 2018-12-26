using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Data;

namespace GoFitness
{
    public class FilesService
    {
        //Add employee
        public void AddEmployee(Employee_class employee)
        {
            if (File.Exists("EmployeeTable.xml") == false)
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create("EmployeeTable.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Employees");

                    xmlWriter.WriteStartElement("Employee");
                    xmlWriter.WriteElementString("First_Name", employee.FirstName.ToString());
                    xmlWriter.WriteElementString("Last_Name", employee.LastName.ToString());
                    xmlWriter.WriteElementString("ID", employee.Id.ToString());
                    xmlWriter.WriteElementString("Age", employee.Age.ToString());
                    xmlWriter.WriteElementString("Phone_Number", employee.PhoneNumber.ToString());
                    xmlWriter.WriteElementString("Email", employee.Email.ToString());
                    xmlWriter.WriteElementString("User_Name", employee.UserName.ToString());
                    xmlWriter.WriteElementString("Password", employee.Password.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load("EmployeeTable.xml");
                XElement root = xDocument.Element("Employees");
                IEnumerable<XElement> rows = root.Descendants("Employee");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Employee",
                   new XElement("First_Name", employee.FirstName.ToString()),
                   new XElement("Last_Name", employee.LastName.ToString()),
                   new XElement("ID", employee.Id.ToString()),
                   new XElement("Age", employee.Age.ToString()),
                   new XElement("Phone_Number", employee.PhoneNumber.ToString()),
                   new XElement("Email", employee.Email.ToString()),
                   new XElement("User_Name", employee.UserName.ToString()),
                   new XElement("Password", employee.Password.ToString())));
                xDocument.Save("EmployeeTable.xml");
            }

        }

        //Remove employee
        public void RemoveEmployee(Employee_class employee)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("EmployeeTable.xml");
            ds.Tables[0].TableName = "Employees";
            for (int i = 0; i < ds.Tables[0].Rows.Count - 1; i++)
            {
                if (employee.Id == ds.Tables[0].Rows[i]["ID"].ToString())
                {
                    ds.Tables[0].Rows[i].Delete();
                    ds.WriteXml("EmployeeTable.xml");
                }
            }

        }

        //Update the information of the employee
        public void UpdateEmployeeInfo(Employee_class employee)
        {

        }

        public void UpdateCourse(Course course)
        {

        }

        //Add product to the shop
        public void AddProduct(Product product)
        {
            if (File.Exists("ShopTable.xml") == false)
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create("ShopTable.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Shop");

                    xmlWriter.WriteStartElement("Product");
                    xmlWriter.WriteElementString("Product_Price", product.ProductPrice.ToString());
                    xmlWriter.WriteElementString("Product_Name", product.ProductName.ToString());
                    xmlWriter.WriteElementString("Product_Code", product.ProductCode.ToString());
                    xmlWriter.WriteElementString("Quantity", product.Quantity.ToString());
                    xmlWriter.WriteElementString("IsAvailable", product.IsAvailable.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load("ShopTable.xml");
                XElement root = xDocument.Element("Shop");
                IEnumerable<XElement> rows = root.Descendants("Product");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Product",
                   new XElement("Product_Price", product.ProductPrice.ToString()),
                   new XElement("Product_Name", product.ProductName.ToString()),
                   new XElement("Product_Code", product.ProductCode.ToString()),
                   new XElement("Quantity", product.Quantity.ToString()),
                   new XElement("IsAvailable", product.IsAvailable.ToString())));
                xDocument.Save("ShopTable.xml");
            }

        }

        //Remove product from shop
        public void RemoveProduct(Product product)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("ShopTable.xml");
            ds.Tables[0].TableName = "Shop";
            for (int i = 0; i < ds.Tables[0].Rows.Count - 1; i++)
            {
                if (product.ProductCode == ds.Tables[0].Rows[i]["Product_Code"].ToString())
                {
                    ds.Tables[0].Rows[i].Delete();
                    ds.WriteXml("ShopTable.xml");
                }
            }

        }

        //Update product details
        public void UpdateProductList(Product product)
        {

        }

        //Add a new customer to our club
        public void AddCustomer(Customer customer)
        {
            if (File.Exists("CustomerTable.xml") == false)
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create("CustomerTable.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("Customers");

                    xmlWriter.WriteStartElement("Customer");
                    xmlWriter.WriteElementString("First_Name", customer.FirstName.ToString());
                    xmlWriter.WriteElementString("Last_Name", customer.LastName.ToString());
                    xmlWriter.WriteElementString("ID", customer.Id.ToString());
                    xmlWriter.WriteElementString("Age", customer.Age.ToString());
                    xmlWriter.WriteElementString("Phone_Number", customer.PhoneNumber.ToString());
                    xmlWriter.WriteElementString("Email", customer.Email.ToString());
                    xmlWriter.WriteElementString("User_Name", customer.UserName.ToString());
                    xmlWriter.WriteElementString("Password", customer.Password.ToString());
                    xmlWriter.WriteStartElement("Courses");
                    xmlWriter.WriteElementString("Course", customer.Course1.ToString());
                    xmlWriter.WriteElementString("Course", customer.Course2.ToString());
                    xmlWriter.WriteElementString("Course", customer.Course3.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load("CustomerTable.xml");
                XElement root = xDocument.Element("Customers");
                IEnumerable<XElement> rows = root.Descendants("Customer");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Customer",
                   new XElement("First_Name", customer.FirstName.ToString()),
                   new XElement("Last_Name", customer.LastName.ToString()),
                   new XElement("ID", customer.Id.ToString()),
                   new XElement("Age", customer.Age.ToString()),
                   new XElement("Phone_Number", customer.PhoneNumber.ToString()),
                   new XElement("Email", customer.Email.ToString()),
                   new XElement("User_Name", customer.UserName.ToString()),
                   new XElement("Password", customer.Password.ToString()),
                   new XElement("Courses",
                       new XElement("Course", customer.Course1.ToString()),
                       new XElement("Course", customer.Course2.ToString()),
                       new XElement("Course", customer.Course3.ToString()))));
                xDocument.Save("CustomerTable.xml");
            }
        }

        //Remove customer
        public void RemoveCustomer(Customer customer)
        {
            DataSet dsCustomer = new DataSet();
            DataSet dsDancing = new DataSet();
            DataSet dsGym = new DataSet();
            DataSet dsSwimming = new DataSet();
            dsCustomer.ReadXml("CustomerTable.xml");
            dsCustomer.Tables[0].TableName = "Customers";
            for (int i = 0; i < dsCustomer.Tables[0].Rows.Count - 1; i++)
            {
                if (customer.Id == dsCustomer.Tables[0].Rows[i]["ID"].ToString())
                {
                    dsCustomer.Tables[0].Rows[i].Delete();
                    dsCustomer.WriteXml("CustomerTable.xml");
                }
            }
            dsDancing.ReadXml("DancingCustomerTable.xml");
            dsDancing.Tables[0].TableName = "Customers";
            for (int i = 0; i < dsDancing.Tables[0].Rows.Count - 1; i++)
            {
                if (customer.Id == dsDancing.Tables[0].Rows[i]["ID"].ToString())
                {
                    dsDancing.Tables[0].Rows[i].Delete();
                    dsDancing.WriteXml("DancingCustomerTable.xml");
                }
            }
            dsGym.ReadXml("GymCustomerTable.xml");
            dsGym.Tables[0].TableName = "Customers";
            for (int i = 0; i < dsGym.Tables[0].Rows.Count - 1; i++)
            {
                if (customer.Id == dsGym.Tables[0].Rows[i]["ID"].ToString())
                {
                    dsGym.Tables[0].Rows[i].Delete();
                    dsGym.WriteXml("GymCustomerTable.xml");
                }
            }
            dsSwimming.ReadXml("SwimmingCustomerTable.xml");
            dsSwimming.Tables[0].TableName = "Customers";
            for (int i = 0; i < dsSwimming.Tables[0].Rows.Count - 1; i++)
            {
                if (customer.Id == dsSwimming.Tables[0].Rows[i]["ID"].ToString())
                {
                    dsSwimming.Tables[0].Rows[i].Delete();
                    dsSwimming.WriteXml("SwimmingCustomerTable.xml");
                }
            }

        }

        public void UpdateCustomer(Customer customer)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("CustomerTable.xml");
            ds.Tables[0].TableName = "Customers";
            for (int i = 0; i < ds.Tables["Customers"].Rows.Count-1 ; i++)
            {
                if (customer.Id == ds.Tables["Customers"].Rows[i]["ID"].ToString())
                {
                    DataRow r = ds.Tables["Customers"].Rows[i];
                    r[0] = customer.FirstName;
                    r[1] = customer.LastName;
                    r[2] = customer.Id;
                    r[3] = customer.Age;
                    r[4] = customer.PhoneNumber;
                    r[5] = customer.Email;
                    r[6] = customer.Weight;
                    r[7] = customer.UserName;
                    r[8] = customer.Password;
                    r[9] = customer.Course1;
                    r[10] = customer.Course2;
                    r[11] = customer.Course3;
                   

                    ds.WriteXml("CustomerTable.xml");

                }
            }






        }
    }
}
