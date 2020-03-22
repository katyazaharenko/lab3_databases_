using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_databases
{
    /// <summary>
    /// Класс <c>MySQL_DBMS</c>,
    /// отвечающий за реализацию методов работы с MySQL.
    /// <list type="bullet">
    /// <item>
    /// <term>CreateTable</term>
    /// <description>Метод для создания таблицы в БД.</description>
    /// </item>
    /// <item>
    /// <term>DropTable</term>
    /// <description>Метод для удаления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>AlterTable</term>
    /// <description>Метод для изменения таблицы.</description>
    /// </item>
    /// <item>
    /// <term>UpdateData</term>
    /// <description>Метод для обновления данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>SelectData</term>
    /// <description>Метод для выборки данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>InsertData</term>
    /// <description>Метод для вставки данных в таблицу.</description>
    /// </item>
    /// <item>
    /// <term>DeleteData</term>
    /// <description>Метод для удаления данных из таблицы.</description>
    /// </item>
    /// <item>
    /// <term>CreateDB</term>
    /// <description>Метод для создания базы данных.</description>
    /// </item>
    /// <item>
    /// <term>GrantOn</term>
    /// <description>Метод для предоставления привилегий на объект БД.</description>
    /// </item>
    /// <item>
    /// <term>RevokeOn</term>
    /// <description>Метод для отмены привилегий на объект БД.</description>
    /// </item>
    /// </list>
    /// </summary>
    public class MySQL_DBMS : IDataBaseManagementSystem
    {
        /// <summary>
        /// Метод для создания таблицы в БД.
        /// </summary>
        public void CreateTable(/*Some input data*/)
        {
            Console.WriteLine("CreateTable of MySQL");
        }
        /// <summary>
        /// Метод для удаления таблицы.
        /// </summary>
        public void DropTable(/*Some input data*/)
        {
            Console.WriteLine("DropTable of MySQL");
        }
        /// <summary>
        /// Метод для изменения таблицы.
        /// </summary>
        public void AlterTable(/*Some input data*/)
        {
            Console.WriteLine("AlterTable of MySQL");
        }
        /// <summary>
        /// Метод для обновления данных таблицы.
        /// </summary>
        public void UpdateData(/*Some input data*/)
        {
            Console.WriteLine("UpdateData of MySQL");
        }
        /// <summary>
        /// Метод для выборки данных таблицы.
        /// </summary>
        public void SelectData(/*Some input data*/)
        {
            Console.WriteLine("SelectData of MySQL");
        }
        /// <summary>
        /// Метод для вставки данных в таблицу.
        /// </summary>
        public void InsertData(/*Some input data*/)
        {
            Console.WriteLine("InsertData of MySQL");
        }

        /// <summary>
        /// Метод для удаления данных из таблицы.
        /// </summary>
        public void DeleteData(/*Some input data*/)
        {
            Console.WriteLine("DeleteData of MySQL");
        }

        /// <summary>
        /// Метод для создания базы данных.
        /// </summary>
        public void CreateDB(/*Some input data*/)
        {
            Console.WriteLine("CreateDB of MySQL");
        }
        /// <summary>
        /// Метод для предоставления привилегий на объект БД.
        /// </summary>      
        public void GrantOn(/*Some input data*/)
        {
            Console.WriteLine("GrantOn of MySQL");
        }
        /// <summary>
        /// Метод для отмены привилегий на объект БД.
        /// </summary>

        public void RevokeOn(/*Some input data*/)
        {
            Console.WriteLine("RevokeOn of MySQL");
        }
    }
    /// <summary>
    /// Класс <c>Oracle_DBMS</c>,
    /// отвечающий за реализацию методов работы с Oracle.
    /// <list type="bullet">
    /// <item>
    /// <term>CreateTable</term>
    /// <description>Метод для создания таблицы в БД.</description>
    /// </item>
    /// <item>
    /// <term>DropTable</term>
    /// <description>Метод для удаления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>AlterTable</term>
    /// <description>Метод для изменения таблицы.</description>
    /// </item>
    /// <item>
    /// <term>UpdateData</term>
    /// <description>Метод для обновления данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>SelectData</term>
    /// <description>Метод для выборки данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>InsertData</term>
    /// <description>Метод для вставки данных в таблицу.</description>
    /// </item>
    /// <item>
    /// <term>DeleteData</term>
    /// <description>Метод для удаления данных из таблицы.</description>
    /// </item>
    /// <item>
    /// <term>CreateDB</term>
    /// <description>Метод для создания базы данных.</description>
    /// </item>
    /// <item>
    /// <term>GrantOn</term>
    /// <description>Метод для предоставления привилегий на объект БД.</description>
    /// </item>
    /// <item>
    /// <term>RevokeOn</term>
    /// <description>Метод для отмены привилегий на объект БД.</description>
    /// </item>
    /// </list>
    /// </summary>
    public class Oracle_DBMS : IDataBaseManagementSystem
    {

        /// <summary>
        /// Метод для создания таблицы в БД.
        /// </summary>
        public void CreateTable(/*Some input data*/)
        {
            Console.WriteLine("CreateTable of Oracle");
        }
        /// <summary>
        /// Метод для удаления таблицы.
        /// </summary>
        public void DropTable(/*Some input data*/)
        {
            Console.WriteLine("DropTable of Oracle");
        }
        /// <summary>
        /// Метод для изменения таблицы.
        /// </summary>
        public void AlterTable(/*Some input data*/)
        {
            Console.WriteLine("AlterTable of Oracle");
        }
        /// <summary>
        /// Метод для обновления данных таблицы.
        /// </summary>
        public void UpdateData(/*Some input data*/)
        {
            Console.WriteLine("UpdateData of Oracle");
        }
        /// <summary>
        /// Метод для выборки данных таблицы.
        /// </summary>
        public void SelectData(/*Some input data*/)
        {
            Console.WriteLine("SelectData of Oracle");
        }
        /// <summary>
        /// Метод для вставки данных в таблицу.
        /// </summary>
        public void InsertData(/*Some input data*/)
        {
            Console.WriteLine("InsertData of Oracle");
        }

        /// <summary>
        /// Метод для удаления данных из таблицы.
        /// </summary>
        public void DeleteData(/*Some input data*/)
        {
            Console.WriteLine("DeleteData of Oracle");
        }

        /// <summary>
        /// Метод для создания базы данных.
        /// </summary>
        public void CreateDB(/*Some input data*/)
        {
            Console.WriteLine("CreateDB of Oracle");
        }
        /// <summary>
        /// Метод для предоставления привилегий на объект БД.
        /// </summary>      
        public void GrantOn(/*Some input data*/)
        {
            Console.WriteLine("GrantOn of Oracle");
        }
        /// <summary>
        /// Метод для отмены привилегий на объект БД.
        /// </summary>

        public void RevokeOn(/*Some input data*/)
        {
            Console.WriteLine("RevokeOn of Oracle");
        }
    }
    /// <summary>
    /// Класс <c>PostgreSQL_DBMS</c>,
    /// отвечающий за реализацию методов работы с PostgreSQL.
    /// <list type="bullet">
    /// <item>
    /// <term>CreateTable</term>
    /// <description>Метод для создания таблицы в БД.</description>
    /// </item>
    /// <item>
    /// <term>DropTable</term>
    /// <description>Метод для удаления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>AlterTable</term>
    /// <description>Метод для изменения таблицы.</description>
    /// </item>
    /// <item>
    /// <term>UpdateData</term>
    /// <description>Метод для обновления данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>SelectData</term>
    /// <description>Метод для выборки данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>InsertData</term>
    /// <description>Метод для вставки данных в таблицу.</description>
    /// </item>
    /// <item>
    /// <term>DeleteData</term>
    /// <description>Метод для удаления данных из таблицы.</description>
    /// </item>
    /// <item>
    /// <term>CreateDB</term>
    /// <description>Метод для создания базы данных.</description>
    /// </item>
    /// <item>
    /// <term>GrantOn</term>
    /// <description>Метод для предоставления привилегий на объект БД.</description>
    /// </item>
    /// <item>
    /// <term>RevokeOn</term>
    /// <description>Метод для отмены привилегий на объект БД.</description>
    /// </item>
    /// </list>
    /// </summary>
    public class PostgreSQL_DBMS : IDataBaseManagementSystem
    {
        /// <summary>
        /// Метод для создания таблицы в БД.
        /// </summary>
        public void CreateTable(/*Some input data*/)
        {
            Console.WriteLine("CreateTable of PostgreSQL");
        }
        /// <summary>
        /// Метод для удаления таблицы.
        /// </summary>
        public void DropTable(/*Some input data*/)
        {
            Console.WriteLine("DropTable of PostgreSQL");
        }
        /// <summary>
        /// Метод для изменения таблицы.
        /// </summary>
        public void AlterTable(/*Some input data*/)
        {
            Console.WriteLine("AlterTable of PostgreSQL");
        }
        /// <summary>
        /// Метод для обновления данных таблицы.
        /// </summary>
        public void UpdateData(/*Some input data*/)
        {
            Console.WriteLine("UpdateData of PostgreSQL");
        }
        /// <summary>
        /// Метод для выборки данных таблицы.
        /// </summary>
        public void SelectData(/*Some input data*/)
        {
            Console.WriteLine("SelectData of PostgreSQL");
        }
        /// <summary>
        /// Метод для вставки данных в таблицу.
        /// </summary>
        public void InsertData(/*Some input data*/)
        {
            Console.WriteLine("InsertData of PostgreSQL");
        }

        /// <summary>
        /// Метод для удаления данных из таблицы.
        /// </summary>
        public void DeleteData(/*Some input data*/)
        {
            Console.WriteLine("DeleteData of PostgreSQL");
        }

        /// <summary>
        /// Метод для создания базы данных.
        /// </summary>
        public void CreateDB(/*Some input data*/)
        {
            Console.WriteLine("CreateDB of PostgreSQL");
        }
        /// <summary>
        /// Метод для предоставления привилегий на объект БД.
        /// </summary>      
        public void GrantOn(/*Some input data*/)
        {
            Console.WriteLine("GrantOn of PostgreSQL");
        }
        /// <summary>
        /// Метод для отмены привилегий на объект БД.
        /// </summary>

        public void RevokeOn(/*Some input data*/)
        {
            Console.WriteLine("RevokeOn of PostgreSQL");
        }
    }
    /// <summary>
    /// Интерфейс <c>IDataBaseManagementSystem</c>.
    /// Представляет методы, реализующие функционал любой СУБД.
    /// <list type="bullet">
    /// <item>
    /// <term>CreateTable</term>
    /// <description>Метод для создания таблицы в БД.</description>
    /// </item>
    /// <item>
    /// <term>DropTable</term>
    /// <description>Метод для удаления таблицы.</description>
    /// </item>
    /// <item>
    /// <term>AlterTable</term>
    /// <description>Метод для изменения таблицы.</description>
    /// </item>
    /// <item>
    /// <term>UpdateData</term>
    /// <description>Метод для обновления данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>SelectData</term>
    /// <description>Метод для выборки данных таблицы.</description>
    /// </item>
    /// <item>
    /// <term>InsertData</term>
    /// <description>Метод для вставки данных в таблицу.</description>
    /// </item>
    /// <item>
    /// <term>DeleteData</term>
    /// <description>Метод для удаления данных из таблицы.</description>
    /// </item>
    /// <item>
    /// <term>CreateDB</term>
    /// <description>Метод для создания базы данных.</description>
    /// </item>
    /// <item>
    /// <term>GrantOn</term>
    /// <description>Метод для предоставления привилегий на объект БД.</description>
    /// </item>
    /// <item>
    /// <term>RevokeOn</term>
    /// <description>Метод для отмены привилегий на объект БД.</description>
    /// </item>
    /// </list>
    /// </summary>
    public interface IDataBaseManagementSystem
    {
        /// <summary>
        /// Метод для создания таблицы в БД.
        /// </summary>
        void CreateTable(/*Some input data*/);
        /// <summary>
        /// Метод для удаления таблицы.
        /// </summary>
        void DropTable(/*Some input data*/);
        /// <summary>
        /// Метод для изменения таблицы.
        /// </summary>
        void AlterTable(/*Some input data*/);
        /// <summary>
        /// Метод для обновления данных таблицы.
        /// </summary>
        void UpdateData(/*Some input data*/);
        /// <summary>
        /// Метод для выборки данных таблицы.
        /// </summary>
        void SelectData(/*Some input data*/);
        /// <summary>
        /// Метод для вставки данных в таблицу.
        /// </summary>
        void InsertData(/*Some input data*/);
        /// <summary>
        /// Метод для удаления данных из таблицы.
        /// </summary>
        void DeleteData(/*Some input data*/);
        /// <summary>
        /// Метод для создания базы данных.
        /// </summary>
        void CreateDB(/*Some input data*/);
        /// <summary>
        /// Метод для предоставления привилегий на объект БД.
        /// </summary>
        void GrantOn(/*Some input data*/);
        /// <summary>
        /// Метод для отмены привилегий на объект БД.
        /// </summary>
        void RevokeOn(/*Some input data*/);

    }
    /// <summary>
    /// Класс-контроллер <c>AccessToDBMS</c>.
    /// <list type="bullet">
    /// <item>
    /// <term>dbms</term>
    /// <description>Поле, представляющее объект класса <c>IDataBaseManagementSystem</c>,
    /// отвечающее за то, к какой СУБД необходим доступ.</description>
    /// </item>
    /// <item>
    /// <term>AccessToDBMS</term>
    /// <description>Конструктор класса.</description>
    /// </item>
    /// <item>
    /// <term>CreateTable</term>
    /// <description>Метод, позволяющий получить доступ к методу CreateTable
    /// через объект dbms.</description>
    /// </item>
    /// <item>
    /// <term>DropTable</term>
    /// <description>Метод, позволяющий получить доступ к методу DropTable
    /// через объект dbms.</description>
    /// </item>
    /// <item>
    /// <term>AlterTable</term>
    /// <description>Метод, позволяющий получить доступ к методу AlterTable
    /// через объект dbms.</description>
    /// </item>
    /// <item>
    /// <term>UpdateData</term>
    /// <description>Метод, позволяющий получить доступ к методу UpdateData
    /// через объект dbms.</description>
    /// </item>
    /// <item>
    /// <term>SelectData</term>
    /// <description>Метод, позволяющий получить доступ к методу SelectData
    /// через объект dbms.</description>
    /// </item>
    /// <item>
    /// <term>InsertData</term>
    /// <description>Метод, позволяющий получить доступ к методу InsertData
    /// через объект dbms.</description>
    /// </item>
    /// <item>
    /// <term>DeleteData</term>
    /// <description>Метод, позволяющий получить доступ к методу DeleteData
    /// через объект dbms.</description>
    /// </item>
    /// <item>
    /// <term>CreateDB</term>
    /// <description>Метод, позволяющий получить доступ к методу CreateDB
    /// через объект dbms.</description>
    /// </item>
    /// <item>
    /// <term>GrantOn</term>
    /// <description>Метод, позволяющий получить доступ к методу GrantOn
    /// через объект dbms.</description>
    /// </item>
    /// <item>
    /// <term>RevokeOn</term>
    /// <description>Метод, позволяющий получить доступ к методу RevokeOn
    /// через объект dbms.</description>
    /// </item>
    /// </list>
    /// </summary>
    public class AccessToDBMS
    {
        /// <summary>
        /// Поле, представляющее объект класса <c>IDataBaseManagementSystem</c>,
        /// отвечающее за то, к какой СУБД необходим доступ.
        /// </summary>
        private readonly IDataBaseManagementSystem dbms;
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public AccessToDBMS(IDataBaseManagementSystem dbms)
        {
            this.dbms = dbms;
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу CreateTable через объект dbms.
        /// </summary>
        public void CreateTable(/*Some input data*/)
        {
            dbms.CreateTable(/*Some input data*/);
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу DropTable через объект dbms.
        /// </summary>
        public void DropTable(/*Some input data*/)
        {
            dbms.DropTable(/*Some input data*/);
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу AlterTable через объект dbms.
        /// </summary>
        public void AlterTable(/*Some input data*/)
        {
            dbms.AlterTable(/*Some input data*/);
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу UpdateData через объект dbms.
        /// </summary>
        public void UpdateData(/*Some input data*/)
        {
            dbms.UpdateData(/*Some input data*/);
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу SelectData через объект dbms.
        /// </summary>
        public void SelectData(/*Some input data*/)
        {
            dbms.SelectData(/*Some input data*/);
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу InsertData через объект dbms.
        /// </summary>
        public void InsertData(/*Some input data*/)
        {
            dbms.InsertData(/*Some input data*/);
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу DeleteData через объект dbms.
        /// </summary>
        public void DeleteData(/*Some input data*/)
        {
            dbms.DeleteData(/*Some input data*/);
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу CreateDB через объект dbms.
        /// </summary>
        public void CreateDB(/*Some input data*/)
        {
            dbms.CreateDB(/*Some input data*/);
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу GrantOn через объект dbms.
        /// </summary>
        public void GrantOn(/*Some input data*/)
        {
            dbms.GrantOn(/*Some input data*/);
        }
        /// <summary>
        /// Метод, позволяющий получить доступ к методу RevokeOn через объект dbms.
        /// </summary>
        public void RevokeOn(/*Some input data*/)
        {
            dbms.RevokeOn(/*Some input data*/);
        }

    }


    /// <summary>
    /// Главный класс Program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Обьявление объекта класса AccessToDBMS.
        /// </summary>
        public static AccessToDBMS accessObj;
        /*Метод, который используется для создания объекта класса AccessToDBMS на основе входных данных.*/
        /// <summary>
        /// Метод InitializeObj для инициализации объекта accessObj на основе данных, полученных от пользователя.
        /// </summary>
        ///<param name="numDBMS">Строка-номер СУБД.</param>
        ///<param name="numsComms">Массив строк-номеров, каждый из которых соответствует команде СУБД.</param>
        private static void InitializeObj(string numDBMS, string[] numsComms)
        {
            switch (numDBMS) /*В зависимости от числа определяется, к какой СУБД нужен доступ.*/
            {
                case "1":
                    MySQL_DBMS mySQL_DBMS = new MySQL_DBMS();
                    accessObj = new AccessToDBMS(mySQL_DBMS);
                    break;
                case "2":
                    Oracle_DBMS oracle_DBMS = new Oracle_DBMS();
                    accessObj = new AccessToDBMS(oracle_DBMS);
                    break;
                case "3":
                    PostgreSQL_DBMS postgreSQL_DBMS = new PostgreSQL_DBMS();
                    accessObj = new AccessToDBMS(postgreSQL_DBMS);
                    break;
                default:
                    throw new Exception("Ошибка при выборе СУБД");
            }
            foreach (string s in numsComms)
            {
                switch (s) /*В зависимости от числа определяется, к какой команде СУБД нужен доступ.*/
                {
                    case "1":
                        accessObj.CreateDB();
                        break;
                    case "2":
                        accessObj.CreateTable();
                        break;
                    case "3":
                        accessObj.DropTable();
                        break;
                    case "4":
                        accessObj.AlterTable();
                        break;
                    case "5":
                        accessObj.UpdateData();
                        break;
                    case "6":
                        accessObj.SelectData();
                        break;
                    case "7":
                        accessObj.InsertData();
                        break;
                    case "8":
                        accessObj.DeleteData();
                        break;
                    case "9":
                        accessObj.GrantOn();
                        break;
                    case "10":
                        accessObj.RevokeOn();
                        break;
                    default:
                        Console.WriteLine("Такой команды не существует.");
                        break;
                }
            }
        }
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                string numDBMS;
                string[] numsComms;
                string commsDBMS;
                /*Запрос у пользователя названия СУБД и необходимых команд.*/
                Console.WriteLine("Введите номер выбранной СУБД:\r\n1. MySQL\r\n2. Oracle\r\n3. PostgreSQL");
                numDBMS = Console.ReadLine();
                Console.WriteLine("Введите через пробел номера команд для выполнения:\r\n1. Create Data Base\r\n2. Create Table\r\n3. Drop Table\r\n" +
                    "4. Alter Table\r\n5. Update Data\r\n6. Select Data\r\n" +
                    "7. Insert Data\r\n8. Delete Data\r\n9. Grant On\r\n10. RevokeOn");
                commsDBMS = Console.ReadLine();
                numsComms = commsDBMS.Split(new char[] { ' ' });
                /*Вызов метода, который соберет объект для доступа к командам СУБД на основе входных данных.*/
                InitializeObj(numDBMS, numsComms);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}