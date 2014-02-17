using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace XmlLibrary
{
    public class XmlHandling
    {
        //this will create xml document base with delacration
        //filename must be given in a form of filename.extension
        public static void createXMLDB(string filename)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;
            //if there is no existing file, we will create new one
            if (!File.Exists(filepath)) 
            {
                XmlDocument doc = new XmlDocument();
                XmlNode decnode = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                doc.AppendChild(decnode);

                XmlNode productsnode = doc.CreateElement("Products");
                doc.AppendChild(productsnode);
                
                doc.Save(filepath);
            }
        }

        public static void addProduct(string filename, string name, string manufacturer, string kcal100g, string carbohydrates, string proteins, string fats, string portion)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;

            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            XmlNode productsnode = doc.SelectSingleNode("/Products");

            //product with same name and manufacturer does not exist
            if (productsnode.SelectSingleNode("Product[@Name='" + name + "' and @Manufacturer='" + manufacturer + "']") == null)
            {
                //creating one product with attributes
                XmlNode productnode = doc.CreateElement("Product");

                XmlAttribute productname = doc.CreateAttribute("Name");
                productname.Value = name;
                productnode.Attributes.Append(productname);
                XmlAttribute productmanufacturer = doc.CreateAttribute("Manufacturer");
                productmanufacturer.Value = manufacturer;
                productnode.Attributes.Append(productmanufacturer);
                XmlAttribute productkcal = doc.CreateAttribute("kcal100g");
                productkcal.Value = kcal100g;
                productnode.Attributes.Append(productkcal);
                XmlAttribute productcarbs = doc.CreateAttribute("Carbohydrates");
                productcarbs.Value = carbohydrates;
                productnode.Attributes.Append(productcarbs);
                XmlAttribute productprots = doc.CreateAttribute("Proteins");
                productprots.Value = proteins;
                productnode.Attributes.Append(productprots);
                XmlAttribute productfats = doc.CreateAttribute("Fats");
                productfats.Value = fats;
                productnode.Attributes.Append(productfats);
                XmlAttribute productportion = doc.CreateAttribute("Portion");
                productportion.Value = portion;
                productnode.Attributes.Append(productportion);

                //by default we will keep the list sorted by name
                //first we check that if this is first product node in the xml collection
                //order will be ascending
                if (productsnode.ChildNodes.Count == 0)
                {
                    productsnode.AppendChild(productnode);
                }
                else
                {
                    bool inserted = false;
                    foreach (XmlNode node in productsnode.ChildNodes)
                    {
                        string temp1 = node.Attributes["Name"].Value.Replace(" ", "");
                        string temp2 = productnode.Attributes["Name"].Value.Replace(" ", "");
                        
                        //lets make our string same lenght strings
                        if (temp1.Length > temp2.Length)
                        {
                            int addition = temp1.Length - temp2.Length;
                            temp2.Insert(temp2.Length - 1, multichar(addition));
                        }
                        else if (temp2.Length > temp1.Length)
                        {
                            int addition = temp2.Length - temp1.Length;
                            temp1.Insert(temp1.Length - 1, multichar(addition));
                        }
                        //temp1 > temp2
                        if (String.Compare(temp1, temp2, true) > 0)
                        {
                            productsnode.InsertBefore(productnode, node);
                            inserted = true;
                            break;
                        }
                    }
                    if (!inserted)
                    {
                        productsnode.AppendChild(productnode);
                    }
                }
                doc.Save(filepath);
            }
        }

        public static void removeProduct(string filename, string name, string manufacturer)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;

            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            XmlNode productsnode = doc.SelectSingleNode("/Products");

            XmlNode removednode = productsnode.SelectSingleNode("Product[@Name='"+name+"' and @Manufacturer='" + manufacturer + "']");

            productsnode.RemoveChild(removednode);

            doc.Save(filepath);
        }

        //gives all products in a list which includes arrays of strings
        public static List<string[]> allProducts(string filename)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;
            List<string[]> result = new List<string[]>();
            
            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);
            XmlNode productsnode = doc.SelectSingleNode("/Products");
            XmlNodeList productsnodelist = productsnode.ChildNodes;
            
            foreach (XmlNode product in productsnodelist)
            {
                string[] productarray = { product.Attributes["Name"].Value, 
                                            product.Attributes["Manufacturer"].Value,
                                            product.Attributes["kcal100g"].Value,
                                            product.Attributes["Carbohydrates"].Value, 
                                            product.Attributes["Proteins"].Value,
                                            product.Attributes["Fats"].Value,
                                            product.Attributes["Portion"].Value };
                result.Add(productarray);
            }
            return result;
        }

        public static void createSettingsXML(string filename)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;
            //if there is no existing file, we will create new one
            if (!File.Exists(filepath))
            {
                XmlDocument doc = new XmlDocument();
                XmlNode decnode = doc.CreateXmlDeclaration("1.0", "UTF-8", "yes");
                doc.AppendChild(decnode);

                XmlNode Settings = doc.CreateElement("Settings");
                doc.AppendChild(Settings);

                XmlNode EULAnode = doc.CreateElement("EULA");
                XmlAttribute EULAaccepted = doc.CreateAttribute("Accepted");
                EULAaccepted.Value = "No";
                EULAnode.Attributes.Append(EULAaccepted);
                XmlAttribute EULAversion = doc.CreateAttribute("Version");
                EULAversion.Value = "0.0";
                EULAnode.Attributes.Append(EULAversion);
                //EULAnode.InnerText = EULA;
                Settings.AppendChild(EULAnode);

                XmlNode Registered = doc.CreateElement("Registered");
                XmlAttribute Reg = doc.CreateAttribute("Registered");
                Reg.Value = "No";
                Registered.Attributes.Append(Reg);
                Settings.AppendChild(Registered);

                doc.Save(filepath);
            }
        }

        public static void acceptEULA(string filename, string EULA, string version)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;

            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            XmlNode EULAnode = doc.SelectSingleNode("/Settings/EULA");
            EULAnode.Attributes[0].Value = "Yes";
            EULAnode.Attributes[1].Value = version;
            EULAnode.InnerText = EULA;

            doc.Save(filepath);
        }

        public static bool EULAaccepted(string filename, string version)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;

            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            XmlNode EULAnode = doc.SelectSingleNode("/Settings/EULA");

            if (EULAnode.Attributes[0].Value == "Yes" && EULAnode.Attributes[1].Value == version)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool registeredUser(string filename)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;

            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            XmlNode regnode = doc.SelectSingleNode("/Settings/Registered");

            if (regnode.Attributes[0].Value == "Yes" && 
                (regnode.InnerText == CreateSHAHash("mitävittua", "kalervo") ||
                    regnode.InnerText == CreateSHAHash("kallata", "kalervo")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void registerUser(string filename, string password)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;

            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            XmlNode regnode = doc.SelectSingleNode("/Settings/Registered");

            if (password == "mitävittua")
            {
                regnode.InnerText = CreateSHAHash("mitävittua", "kalervo");
                regnode.Attributes[0].Value = "Yes";
                doc.Save(filepath);
            }
            else if (password == "kallata")
            {
                regnode.InnerText = CreateSHAHash("kallata", "kalervo");
                regnode.Attributes[0].Value = "Yes";
                doc.Save(filepath);
            }
        }

        public static string registeredUserName(string filename)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;

            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);

            XmlNode regnode = doc.SelectSingleNode("/Settings/Registered");

            if (regnode.InnerText == CreateSHAHash("mitävittua", "kalervo"))
            {
                return "Jussi Ahola";
            }
            else if (regnode.InnerText == CreateSHAHash("kallata", "kalervo"))
            {
                return "Heini Hakalahti";
            }
            return "Tuntematon";
        }
        //this will combine 2 databases, filename is original and dbname is the one
        //which data will be copied
        public static void combineDB(string filename, string dbname)
        {
            string filepath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + filename;
            //string dbpath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\" + dbname;

            XmlDocument doc = new XmlDocument();
            doc.Load(filepath);
            XmlDocument db = new XmlDocument();
            db.Load(dbname);

            XmlNode productsnode = doc.SelectSingleNode("/Products");
            XmlNode dbnode = db.SelectSingleNode("/Products");
            XmlNodeList dbnodelist = dbnode.ChildNodes;

            foreach (XmlNode dbproduct in dbnodelist)
            {
                addProductNode(ref productsnode, dbproduct.Attributes[0].Value,
                    dbproduct.Attributes[1].Value, dbproduct.Attributes[2].Value,
                    dbproduct.Attributes[3].Value, dbproduct.Attributes[4].Value,
                    dbproduct.Attributes[5].Value, dbproduct.Attributes[6].Value);
            }
            doc.Save(filepath);
            
        }

        //multiplies character to string for multi number of times
        private static string multichar(int multi)
        {
            string result = "";
            for (int i = 0; i < multi; ++i)
            {
                result += "a";
            }
            return result;
        }

        //NOT DONE!
        //will add xmlnode to the xmlnodelist into the correct place so the list will stay sorted
        private static void addProductNode(ref XmlNode productsnode, string name, string manufacturer, string kcal100g, string carbohydrates, string proteins, string fats, string portion)
        {
            XmlDocument doc = new XmlDocument();
            //product with same name and manufacturer does not exist
            if (productsnode.SelectSingleNode("Product[@Name='" + name + "' and @Manufacturer='" + manufacturer + "']") == null)
            {
                //creating one product with attributes
                XmlNode productnode = doc.CreateElement("Product");

                XmlAttribute productname = doc.CreateAttribute("Name");
                productname.Value = name;
                productnode.Attributes.Append(productname);
                XmlAttribute productmanufacturer = doc.CreateAttribute("Manufacturer");
                productmanufacturer.Value = manufacturer;
                productnode.Attributes.Append(productmanufacturer);
                XmlAttribute productkcal = doc.CreateAttribute("kcal100g");
                productkcal.Value = kcal100g;
                productnode.Attributes.Append(productkcal);
                XmlAttribute productcarbs = doc.CreateAttribute("Carbohydrates");
                productcarbs.Value = carbohydrates;
                productnode.Attributes.Append(productcarbs);
                XmlAttribute productprots = doc.CreateAttribute("Proteins");
                productprots.Value = proteins;
                productnode.Attributes.Append(productprots);
                XmlAttribute productfats = doc.CreateAttribute("Fats");
                productfats.Value = fats;
                productnode.Attributes.Append(productfats);
                XmlAttribute productportion = doc.CreateAttribute("Portion");
                productportion.Value = portion;
                productnode.Attributes.Append(productportion);

                //by default we will keep the list sorted by name
                //first we check that if this is first product node in the xml collection
                //order will be ascending
                if (productsnode.ChildNodes.Count == 0)
                {
                    productsnode.AppendChild(productnode);
                }
                else
                {
                    bool inserted = false;
                    foreach (XmlNode node in productsnode.ChildNodes)
                    {
                        string temp1 = node.Attributes["Name"].Value.Replace(" ", "");
                        string temp2 = productnode.Attributes["Name"].Value.Replace(" ", "");

                        //lets make our string same lenght strings
                        if (temp1.Length > temp2.Length)
                        {
                            int addition = temp1.Length - temp2.Length;
                            temp2.Insert(temp2.Length - 1, multichar(addition));
                        }
                        else if (temp2.Length > temp1.Length)
                        {
                            int addition = temp2.Length - temp1.Length;
                            temp1.Insert(temp1.Length - 1, multichar(addition));
                        }
                        //temp1 > temp2
                        if (String.Compare(temp1, temp2, true) > 0)
                        {
                            productsnode.InsertBefore(productsnode.OwnerDocument.ImportNode(productnode, false), node);
                            inserted = true;
                            break;
                        }
                    }
                    if (!inserted)
                    {
                        productsnode.AppendChild(productsnode.OwnerDocument.ImportNode(productnode, false));
                    }
                }
            }
        }

        //creates sha-2 hash
        public static string CreateSHAHash(string Password, string Salt)
        {
            System.Security.Cryptography.SHA512Managed HashTool = new System.Security.Cryptography.SHA512Managed();
            Byte[] PasswordAsByte = System.Text.Encoding.UTF8.GetBytes(string.Concat(Password, Salt));
            Byte[] EncryptedBytes = HashTool.ComputeHash(PasswordAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(EncryptedBytes);
        }

    }
}
