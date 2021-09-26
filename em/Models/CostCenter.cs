﻿using em.DBAccess;
using em.Helpers;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace em.Models
{
    public class CostCenter
    {
        public int Id { get; set; }
        public int IdCode { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public bool IsActual { get; set; }
        public bool IsTechnology { get; set; }

        public static List<CostCenter> ToList(SelectChoise isActual, SelectChoise isMain, SelectChoise isTechnology)
        {
            string isActualSrt = isActual == SelectChoise.All ? "" : isActual == SelectChoise.True ? " AND IsActual = 1" : " AND IsActual = 0";
            string isMainStr = isMain == SelectChoise.All ? "" : isMain == SelectChoise.True ? " AND IsMain = 1" : " AND IsMain = 0"; ;
            string isTechnologyStr = isTechnology == SelectChoise.All ? "" : isTechnology == SelectChoise.True ? " AND isTechnology = 1" : " AND isTechnology = 0";
            string whereStr = "WHERE True" + isActualSrt + isMainStr + isTechnologyStr;

            List<CostCenter> rez = new();
            string SQLtxt = "SELECT IdCode, Name, IsMain, IsActual, IsTechnology FROM CostCenters " + whereStr + " ORDER BY IdCode";

            using (SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand(SQLtxt, db);
                SqliteDataReader q = selectCommand.ExecuteReader();
                while (q.Read())
                {
                    rez.Add(new CostCenter()
                    {
                        Id = q.GetInt32(0),
                        Name = q.GetString(1),
                        IsMain = q.GetBoolean(2),
                        IsActual = q.GetBoolean(3),
                        IsTechnology = q.GetBoolean(4)
                    });
                }
            }
            return rez;
        }
        public static List<Person> ActualToList()
        {
            List<Person> rez = new ();
            rez.AddRange(from r in ToList(isActual: SelectChoise.True, isMain: SelectChoise.All, isTechnology: SelectChoise.All)
                         select new Person { Id = r.Id, Name = r.Name });
            return rez;
        }

        public static void Add(int id, string name, int ismain, int istechnology, int isactual)
        {
            string sql = "INSERT INTO CostCenters (IdCode, Name, IsMain, IsTechnology, IsActual) VALUES ("
                            + id.ToString() + ", '" + name + "'" + ", " + ismain.ToString() + ", " 
                            + istechnology.ToString() + ", " + isactual.ToString() + ")";

            SqliteCommand insertCommand;
            using SqliteConnection db = new($"Filename={Global.dbpath}");
            db.Open();
            using (SqliteTransaction transaction = db.BeginTransaction())
            {
                insertCommand = db.CreateCommand();
                insertCommand.CommandText = sql;
                insertCommand.ExecuteNonQuery();
                transaction.Commit();
            }
            db.Close();
        }
        public static void Delete(int id)
        {
            string sql = "Delete FROM CostCenters  WHERE IdCode = " + id.ToString(); 
            SqliteCommand insertCommand;
            using SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}");
            db.Open();
            using (SqliteTransaction transaction = db.BeginTransaction())
            {
                insertCommand = db.CreateCommand();
                insertCommand.CommandText = sql;
                insertCommand.ExecuteNonQuery();
                transaction.Commit();
            }
            db.Close();

        }
        public static void Update(int id, string name, int ismain, int istechnology, int isactual)
        {
            string sql = "UPDATE CostCenters SET (Name, IsMain, IsTechnology, IsActual) = ("
                            + "'" + name + "'" + ", " + ismain.ToString() + ", " + istechnology.ToString() + ", " + isactual.ToString() + ")"
                            + "WHERE IdCode = " + id.ToString(); ;
            SqliteCommand insertCommand;
            using SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}");
            db.Open();
            using (SqliteTransaction transaction = db.BeginTransaction())
            {
                insertCommand = db.CreateCommand();
                insertCommand.CommandText = sql;
                insertCommand.ExecuteNonQuery();
                transaction.Commit();
            }
            db.Close();
        }
    }
}
