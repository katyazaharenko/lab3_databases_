using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_databases
{
    class Program
    {
        public static UserOfDBMS user;
        static void Main(string[] args)
        {
            try
            {
                string numDBMS;
                string[] numsComms;
                string commsDBMS;
                
                Console.WriteLine("Введите номер выбранной СУБД:\r\n1. MySQL\r\n2. Oracle\r\n3. PostgreSQL");
                numDBMS = Console.ReadLine();
                Console.WriteLine("Введите через пробел номера команд для выполнения:\r\n1. Create Data Base\r\n2. Create Table\r\n3. Drop Table\r\n" +
                    "4. Alter Table\r\n5. Update Data\r\n6. Select Data\r\n" +
                    "7. Insert Data\r\n8. Delete Data\r\n9. Grant On\r\n10. RevokeOn");
                commsDBMS = Console.ReadLine();
                numsComms = commsDBMS.Split(new char[] { ' ' });
                CreateObject(numDBMS, numsComms);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        /*Метод, который используется для создания объекта класса UserOfDBMS на основе входных данных.*/
        private static void CreateObject(string numDBMS,string[]numsComms)
        {
            switch (numDBMS)
            {
                case "1":
                    MySQL_DBMS mySQL_DBMS = new MySQL_DBMS();
                    user = new UserOfDBMS(mySQL_DBMS);
                    break;
                case "2":
                    Oracle_DBMS oracle_DBMS = new Oracle_DBMS();
                    user = new UserOfDBMS(oracle_DBMS);
                    break;
                case "3":
                    PostgreSQL_DBMS postgreSQL_DBMS = new PostgreSQL_DBMS();
                    user = new UserOfDBMS(postgreSQL_DBMS);
                    break;
                default:
                    throw new Exception("Ошибка при выборе СУБД");
            }
            foreach (string s in numsComms)
            {
                switch (s)
                {
                    case "1":
                        user.CreateDB();
                        break;
                    case "2":
                        user.CreateTable();
                        break;
                    case "3":
                        user.DropTable();
                        break;
                    case "4":
                        user.AlterTable();
                        break;
                    case "5":
                        user.UpdateData();
                        break;
                    case "6":
                        user.SelectData();
                        break;
                    case "7":
                        user.InsertData();
                        break;
                    case "8":
                        user.DeleteData();
                        break;
                    case "9":
                        user.GrantOn();
                        break;
                    case "10":
                        user.RevokeOn();
                        break;
                    default:
                        Console.WriteLine("Такой команды не существует.");
                        break;
                }

            } 
            
        }

    }
    /*Класс-контроллер, позволяющий обратиться к методам любой СУБД*/
    public class UserOfDBMS
    {
        private readonly IDataBaseManagementSystem dbms;
        public UserOfDBMS(IDataBaseManagementSystem dbms)
        {
            this.dbms = dbms;
        }
        
        public void CreateTable()
        {
            dbms.CreateTable(/*Some input data*/);
        }
        public void DropTable()
        {
            dbms.DropTable(/*Some input data*/);
        }
        public void AlterTable()
        {
            dbms.AlterTable(/*Some input data*/);
        }
        public void UpdateData()
        {
            dbms.UpdateData(/*Some input data*/);
        }
        public void SelectData()
        {
            dbms.SelectData(/*Some input data*/);
        }
        public void InsertData()
        {
            dbms.InsertData(/*Some input data*/);
        }
        public void DeleteData()
        {
            dbms.DeleteData(/*Some input data*/);
        }
        public void CreateDB()
        {
            dbms.CreateDB(/*Some input data*/);
        }
        public void GrantOn()
        {
            dbms.GrantOn(/*Some input data*/);
        }
        public void RevokeOn()
        {
            dbms.RevokeOn(/*Some input data*/);
        }
        
    }
    /*Интерфейс, отвечающий за реализацию методов работы с любой СУБД.*/
    public interface IDataBaseManagementSystem
    {
        void CreateTable(/*Some input data*/);
        void DropTable(/*Some input data*/);
        void AlterTable(/*Some input data*/);
        void UpdateData(/*Some input data*/);
        void SelectData(/*Some input data*/);
        void InsertData(/*Some input data*/);
        void DeleteData(/*Some input data*/);
        void CreateDB(/*Some input data*/);
        void GrantOn(/*Some input data*/);
        void RevokeOn(/*Some input data*/);

    }
    /*Класс, отвечающий за реализацию методов работы с MySQL.*/
    public class MySQL_DBMS : IDataBaseManagementSystem
    {
      
        public void CreateTable(/*Some input data*/) 
        {
            Console.WriteLine("CreateTable of MySQL");
        }
        public void DropTable(/*Some input data*/)
        {
            Console.WriteLine("DropTable of MySQL");
        }
        public void AlterTable(/*Some input data*/)
        {
            Console.WriteLine("AlterTable of MySQL");
        }
        public void UpdateData(/*Some input data*/)
        {
            Console.WriteLine("UpdateData of MySQL");
        }
        public void SelectData(/*Some input data*/)
        {
            Console.WriteLine("SelectData of MySQL");
        }
        public void InsertData(/*Some input data*/)
        {
            Console.WriteLine("InsertData of MySQL");
        }
        public void DeleteData(/*Some input data*/)
        {
            Console.WriteLine("DeleteData of MySQL");
        }
        public void CreateDB(/*Some input data*/)
        {
            Console.WriteLine("CreateDB of MySQL");
        }
        public void GrantOn(/*Some input data*/)
        {
            Console.WriteLine("GrantOn of MySQL");
        }
        public void RevokeOn(/*Some input data*/)
        {
            Console.WriteLine("RevokeOn of MySQL");
        }
    }
    /*Класс, отвечающий за реализацию методов работы с Oracle.*/
    public class Oracle_DBMS : IDataBaseManagementSystem
    {
        
        public void CreateTable(/*Some input data*/)
        {
            Console.WriteLine("CreateTable of Oracle");
        }
        public void DropTable(/*Some input data*/)
        {
            Console.WriteLine("DropTable of Oracle");
        }
        public void AlterTable(/*Some input data*/)
        {
            Console.WriteLine("AlterTable of Oracle");
        }
        public void UpdateData(/*Some input data*/)
        {
            Console.WriteLine("UpdateData of Oracle");
        }
        public void SelectData(/*Some input data*/)
        {
            Console.WriteLine("SelectData of Oracle");
        }
        public void InsertData(/*Some input data*/)
        {
            Console.WriteLine("InsertData of Oracle");
        }
        public void DeleteData(/*Some input data*/)
        {
            Console.WriteLine("DeleteData of Oracle");
        }
        public void CreateDB(/*Some input data*/)
        {
            Console.WriteLine("CreateDB of Oracle");
        }
        public void GrantOn(/*Some input data*/)
        {
            Console.WriteLine("GrantOn of Oracle");
        }
        public void RevokeOn(/*Some input data*/)
        {
            Console.WriteLine("RevokeOn of Oracle");
        }
    }
    /*Класс, отвечающий за реализацию методов работы с PostgreSQL.*/
    public class PostgreSQL_DBMS : IDataBaseManagementSystem
    {
        
        public void CreateTable(/*Some input data*/)
        {
            Console.WriteLine("CreateTable of PostgreSQL");
        }
        public void DropTable(/*Some input data*/)
        {
            Console.WriteLine("DropTable of PostgreSQL");
        }
        public void AlterTable(/*Some input data*/)
        {
            Console.WriteLine("AlterTable of PostgreSQL");
        }
        public void UpdateData(/*Some input data*/)
        {
            Console.WriteLine("UpdateData of PostgreSQL");
        }
        public void SelectData(/*Some input data*/)
        {
            Console.WriteLine("SelectData of PostgreSQL");
        }
        public void InsertData(/*Some input data*/)
        {
            Console.WriteLine("InsertData of PostgreSQL");
        }
        public void DeleteData(/*Some input data*/)
        {
            Console.WriteLine("DeleteData of PostgreSQL");
        }
        public void CreateDB(/*Some input data*/)
        {
            Console.WriteLine("CreateDB of PostgreSQL");
        }
        public void GrantOn(/*Some input data*/)
        {
            Console.WriteLine("GrantOn of PostgreSQL");
        }
        public void RevokeOn(/*Some input data*/)
        {
            Console.WriteLine("RevokeOn of PostgreSQL");
        }
    }
}
