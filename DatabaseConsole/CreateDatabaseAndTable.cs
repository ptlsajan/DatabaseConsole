using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;


namespace DatabaseConsole
{

    public class CreateDatabaseAndTable
    {
        /*
        SQLiteConnection sqlite_conn;
        sqlite_conn = CreateConnection();

        //CreateTable(sqlite_conn);

        //InsertData(sqlite_conn);

        ReadData(sqlite_conn);

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;New=True;Compress=True;");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }

        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE Cust(CustomerID INTEGER PRIMARY KEY,Name TEXT, Mobile TEXT)";
            string Createsql1 = "CREATE TABLE Trans(TranscationID INTEGER,StartTime TEXT, EndTime TEXT,FOREIGN KEY(TranscationID) REFERENCES Cust(CustomerID))";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
            Console.WriteLine("Tables created successfully");

        }

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            /*    sqlite_cmd.CommandText = "INSERT INTO Cust(CustomerID,Name,Mobile) VALUES(1,'Sajan','1234567890'); ";
                     sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = "INSERT INTO Cust(CustomerID,Name,Mobile) VALUES(2,'Meshva','5432167890'); "; 
                sqlite_cmd.ExecuteNonQuery();//

            sqlite_cmd.CommandText = "INSERT INTO Trans(TranscationID,StartTime,EndTime) VALUES(1,'10:30','14:30'); ";
            sqlite_cmd.ExecuteNonQuery();

            Console.WriteLine("Inserted Data successfully");
        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = @"


    SELECT c.Name, t.TranscationID
    FROM Cust c, Trans t
    LEFT JOIN Cust c ON p.CustomerID = t.TranscationID
    
        
    ";

            //    SELECT * FROM Cust,Trans WHERE CustomerID=TranscationID;
            //  LEFT JOIN Trans c2 ON p.cid = c2.cid

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string name = sqlite_datareader.GetString(1);
                Console.WriteLine(name);
            }
            conn.Close();

 
        }
    
              */
    }


}
