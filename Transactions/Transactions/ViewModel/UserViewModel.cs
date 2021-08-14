using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using Transactions.Model;
using System.Data;
using System.Xml.Linq;
using System.Xml;
using System.Linq;

namespace Transactions.ViewModel
{
    class UserViewModel
    {
        private IList<User> userList;
        string xml= System.IO.Path.GetFullPath(@"..\..\..\")+"transactions.xml";
        public UserViewModel()
        {
            userList = new List<User>();


            readXML();

        }
        public IList<User> Users
        {
            get { return userList; }
            set { userList = value; }
        }
        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
        public void readXML()
        {
            userList = new List<User>();
            DataSet set = new DataSet();
            set.ReadXml(xml);
            DataTable view = set.Tables[0];
            for(int i = 0; i<set.Tables[0].Rows.Count;i++)
            {
                userList.Add(new User {Item = set.Tables[0].Rows[i].ItemArray[0].ToString(), Amount = Convert.ToInt32(set.Tables[0].Rows[i].ItemArray[1].ToString())});   
            }



        }
        public void loadXML(string file)
        {
            xml = file;
            readXML();
            
        }
        public void deleteXML(string items, int amount)
        {
            XDocument doc = XDocument.Load(xml);
            var nde = (from xml in doc.Descendants("transaction") where xml.Element("item").Value==items && xml.Element("price").Value==amount.ToString() select xml);
            nde.Remove();
            doc.Save(xml);
            readXML();
        }
        public void addXML(string item, int amount)
        {
            XDocument doc = XDocument.Load(xml);
            XElement items = new XElement("transaction");
            items.Add(new XElement("item", item));
            items.Add(new XElement("price", amount));
            doc.Element("transactions").Add(items);
            doc.Save(xml);
            readXML();
        }
        private class Updater : ICommand
        {

            public bool CanExecute(object parameter)
            {
                return true;
            }
            public event EventHandler CanExecuteChanged;
            public void Execute(object parameter)
            {

            }
        }
    }
}
