﻿using em.DBAccess;
using em.Helpers;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace em.Models
{
    public class ReportField
    {
        public int Period { get; set; }
        public int IdCC { get; set; }
        public string CCName { get; set; }
        public int IsCCMain { get; set; }
        public int IsCCTechnology { get; set; }
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public int IsNorm { get; set; }
        public int IsTechnology { get; set; }
        public int IdER { get; set; }
        public string ERName { get; set; }
        public int IsERMain { get; set; }
        public int IsERPrime { get; set; }
        public string UnitName { get; set; }
        public double Fact { get; set; }
        public double Plan { get; set; }
        public double Diff { get; set; }
        public double FactCost { get; set; }
        public double PlanCost { get; set; }
        public double DiffCost { get; set; }

        public ReportField(int v1, int v2, string v3, int v4, int v5, int v6, string v7, int v8, int v9, int v10, string v11, int v12, int v13, string v14, int v15, double v16, double v17, int v18, double v19, double v20)
        {
            Period = v1;
            IdCC = v2;
            CCName = v3;
            IsCCMain = v4;
            IsCCTechnology = v5;
            IdProduct = v6;
            ProductName = v7;
            IsNorm = v8;
            IsTechnology = v9;
            IdER = v10;
            ERName = v11;
            IsERMain = v12;
            IsERPrime = v13;
            UnitName = v14;
            Fact = v15;
            Plan = v16;
            Diff = v17;
            FactCost = v18;
            PlanCost = v19;
            DiffCost = v20;
        }


        //public double FactLoss { get; set; }
        //public double NormLoss { get; set; }
        //public double DiffLoss { get; set; }
        //public double FactLossCost { get; set; }
        //public double NormLossCost { get; set; }
        //public double DiffLossCost { get; set; }
        //public double FactLossProc { get; set; }
        //public double NormLossProc { get; set; }

        //public double Produced { get; set; }
        //public double PlanPrev { get; set; }
        //public double FactPrev { get; set; }
        //public double dFactLimit { get; set; }
        //public double dFactNormative { get; set; }
        //public double FactUseVirtual { get; set; }
        //public double FactVirtualCost { get; set; }
        //public double dFactLimitCost { get; set; }
        //public double dFactNormativeCost { get; set; }
        //public double dFact { get; set; }
        //public double dFactCost { get; set; }
        //public double FactCorrectedCost { get; set; }

        //internal static double Sum(Func<object, object> p)
        //{
        //    throw new NotImplementedException();
        //}

        //public static List<FullFields> RetUseFromER(List<Person> dateSel, List<Person> ccSel, List<Person> erSel, string prSel)
        //{
        //    List<FullFields> rez = new List<FullFields>();
        //    string sqlFilterFromPR = prSel == "все" ? "" : prSel == "на производство" ? "AND IsTechnology = 1" : "AND IsTechnology = 0";
        //    using (SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}"))
        //    {
        //        db.Open();
        //        string SQLtxt = "SELECT Period, Kvart, IdCC, CCName, IsCCMain, IsCCTechnology, "
        //                        + "IdER, ERName, ERShortName, IsERMain, IsERPrime, UnitName, "
        //                        + "IdProduct, ProductName, "
        //                        + "SUM(Fact) as Fact, SUM(Plan) as Plan, SUM(Diff) as Diff, SUM(FactCost) as FactCost, SUM(PlanCost) as PlanCost, SUM(DiffCost) as DiffCost, "
        //                        + "IsNorm, IsTechnology, Produced "
        //                        + "FROM UseAllCosts WHERE NOT(IdCC == 56 AND IdER == 966) "
        //                        + "AND Period IN " + Global.ListToSting(dateSel) + " "
        //                        + "AND IdCC IN " + Global.ListToSting(ccSel) + " "
        //                        + "AND IdER IN " + Global.ListToSting(erSel) + " "
        //                        + sqlFilterFromPR + " "
        //                        + "GROUP BY IdER "
        //                        + "ORDER BY IdER";
        //        SqliteCommand selectCommand = new SqliteCommand(SQLtxt, db);

        //        SqliteDataReader q = selectCommand.ExecuteReader();
        //        while (q.Read())
        //        {
        //            FullFields r = new FullFields();
        //            //r.Period = q.GetInt32(0);
        //            //r.Year = r.Period / 100;
        //            //r.Month = r.Period - r.Year * 100;
        //            //r.PeriodStr = r.Year + "_" + (r.Month < 10 ? "0" + r.Month : r.Month);
        //            //r.Kvart = q.GetInt32(1);
        //            //r.Season = r.Kvart <= 2 ? 1 : 2;
        //            //r.IdCC = q.GetInt32(2);
        //            //r.CCName = q.GetString(3);
        //            //r.IsCCMain = q.GetBoolean(4);
        //            //r.IsCCTechnology = q.GetBoolean(5);
        //            r.IdER = q.GetInt32(6);
        //            r.ERName = q.GetString(7);
        //            r.ERShortName = q.GetString(8);
        //            r.IsERMain = q.GetBoolean(9);
        //            r.IsERPrime = q.GetBoolean(10);
        //            r.UnitName = q.GetString(11);
        //            //r.IdProduct = q.GetInt32(12);
        //            //r.ProductName = q.GetString(13);
        //            r.Fact = q.GetDouble(14);
        //            r.Plan = q.GetDouble(15);
        //            r.Diff = q.GetDouble(16);
        //            r.FactCost = q.GetDouble(17);
        //            r.PlanCost = q.GetDouble(18);
        //            r.DiffCost = q.GetDouble(19);
        //            r.DiffProc = r.Plan > 0 ? r.Diff * 100 / r.Plan : 0;
        //            //r.IsNorm = q.GetBoolean(20);
        //            //r.Produced = q.GetDouble(22);
        //            rez.Add(r);
        //        }
        //    }
        //    return rez;
        //}
        //public static List<FullFields> RetUseFromCC(List<Person> dateSel, List<Person> ccSel, List<Person> erSel, string prSel)
        //{
        //    List<FullFields> rez = new List<FullFields>();
        //    string sqlFilterFromPR = prSel == "все" ? "" : prSel == "на производство" ? "AND IsTechnology = 1" : "AND IsTechnology = 0";
        //    using (SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}"))
        //    {
        //        //string aaa = Global.ListToSting(ccSel);
        //        db.Open();
        //        string SQLtxt = "SELECT Period, Kvart, IdCC, CCName, IsCCMain, IsCCTechnology, "
        //                        + "IdER, ERName, ERShortName, IsERMain, IsERPrime, UnitName, "
        //                        + "IdProduct, ProductName, "
        //                        + "SUM(Fact) as Fact, SUM(Plan) as Plan, SUM(Diff) as Diff, SUM(FactCost) as FactCost, SUM(PlanCost) as PlanCost, SUM(DiffCost) as DiffCost, "
        //                        + "IsNorm, IsTechnology, Produced "
        //                        + "FROM UseAllCosts WHERE NOT(IdCC == 56 AND IdER == 966) "
        //                        + "AND Period IN " + Global.ListToSting(dateSel) + " "
        //                        + "AND IdCC IN " + Global.ListToSting(ccSel) + " "
        //                        + "AND IdER IN " + Global.ListToSting(erSel) + " "
        //                        + sqlFilterFromPR + " "
        //                        + "GROUP BY IdCC "
        //                        + "ORDER BY IdER";
        //        SqliteCommand selectCommand = new SqliteCommand(SQLtxt, db);

        //        SqliteDataReader q = selectCommand.ExecuteReader();
        //        while (q.Read())
        //        {
        //            FullFields r = new FullFields();
        //            //r.Period = q.GetInt32(0);
        //            //r.Year = r.Period / 100;
        //            //r.Month = r.Period - r.Year * 100;
        //            //r.PeriodStr = r.Year + "_" + (r.Month < 10 ? "0" + r.Month : r.Month);
        //            //r.Kvart = q.GetInt32(1);
        //            //r.Season = r.Kvart <= 2 ? 1 : 2;
        //            r.IdCC = q.GetInt32(2);
        //            r.CCName = q.GetString(3);
        //            r.IsCCMain = q.GetBoolean(4);
        //            r.IsCCTechnology = q.GetBoolean(5);
        //            r.IdER = q.GetInt32(6);
        //            r.ERName = q.GetString(7);
        //            r.ERShortName = q.GetString(8);
        //            r.IsERMain = q.GetBoolean(9);
        //            r.IsERPrime = q.GetBoolean(10);
        //            r.UnitName = q.GetString(11);
        //            //r.IdProduct = q.GetInt32(12);
        //            //r.ProductName = q.GetString(13);
        //            r.Fact = q.GetDouble(14);
        //            r.Plan = q.GetDouble(15);
        //            r.Diff = q.GetDouble(16);
        //            r.FactCost = q.GetDouble(17);
        //            r.PlanCost = q.GetDouble(18);
        //            r.DiffCost = q.GetDouble(19);
        //            r.DiffProc = r.Plan > 0 ? r.Diff * 100 / r.Plan : 0;
        //            //r.IsNorm = q.GetBoolean(20);
        //            //r.Produced = q.GetDouble(22);
        //            rez.Add(r);
        //        }
        //    }
        //    return rez;
        //}
        //public static List<FullFields> RetUseFromPR(List<Person> dateSel, List<Person> ccSel, List<Person> erSel, string prSel)
        //{
        //    List<FullFields> rez = new List<FullFields>();
        //    string sqlFilterFromPR = prSel == "все" ? "" : prSel == "на производство" ? "AND IsTechnology = 1" : "AND IsTechnology = 0";
        //    using (SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}"))
        //    {
        //        db.Open();
        //        string SQLtxt = "SELECT Period, Kvart, IdCC, CCName, IsCCMain, IsCCTechnology, "
        //                        + "IdER, ERName, ERShortName, IsERMain, IsERPrime, UnitName, "
        //                        + "IdProduct, ProductName, "
        //                        + "SUM(Fact) as Fact, SUM(Plan) as Plan, SUM(Diff) as Diff, SUM(FactCost) as FactCost, SUM(PlanCost) as PlanCost, SUM(DiffCost) as DiffCost, "
        //                        + "IsNorm, IsTechnology, Produced "
        //                        + "FROM UseAllCosts WHERE NOT(IdCC == 56 AND IdER == 966) "
        //                        + "AND Period IN " + Global.ListToSting(dateSel) + " "
        //                        + "AND IdCC IN " + Global.ListToSting(ccSel) + " "
        //                        + "AND IdER IN " + Global.ListToSting(erSel) + " "
        //                        + sqlFilterFromPR + " "
        //                        + "GROUP BY IdProduct "
        //                        + "ORDER BY IdProduct";
        //        SqliteCommand selectCommand = new SqliteCommand(SQLtxt, db);

        //        SqliteDataReader q = selectCommand.ExecuteReader();
        //        while (q.Read())
        //        {
        //            FullFields r = new FullFields();
        //            //r.Period = q.GetInt32(0);
        //            //r.Year = r.Period / 100;
        //            //r.Month = r.Period - r.Year * 100;
        //            //r.PeriodStr = r.Year + "_" + (r.Month < 10 ? "0" + r.Month : r.Month);
        //            //r.Kvart = q.GetInt32(1);
        //            //r.Season = r.Kvart <= 2 ? 1 : 2;
        //            r.IdER = q.GetInt32(6);
        //            r.ERName = q.GetString(7);
        //            //r.IsCCMain = q.GetBoolean(4);
        //            //r.IsCCTechnology = q.GetBoolean(5);
        //            r.IdProduct = q.GetInt32(12);
        //            r.ProductName = q.GetString(13);
        //            //r.ERShortName = q.GetString(8);
        //            //r.IsERMain = q.GetBoolean(9);
        //            //r.IsERPrime = q.GetBoolean(10);
        //            r.UnitName = q.GetString(11);
        //            //r.IdProduct = q.GetInt32(12);
        //            //r.ProductName = q.GetString(13);
        //            r.Fact = q.GetDouble(14);
        //            r.Plan = q.GetDouble(15);
        //            r.Diff = q.GetDouble(16);
        //            r.FactCost = q.GetDouble(17);
        //            r.PlanCost = q.GetDouble(18);
        //            r.DiffCost = q.GetDouble(19);
        //            r.DiffProc = r.Plan > 0 ? r.Diff * 100 / r.Plan : 0;
        //            //r.IsNorm = q.GetBoolean(20);
        //            //r.Produced = q.GetDouble(22);
        //            rez.Add(r);
        //        }
        //    }
        //    return rez;
        //}
        //public static List<FullFields> RetUsePeriodFromER(List<Person> dateSel, List<Person> ccSel, List<Person> erSel, string prSel)
        //{
        //    List<FullFields> rez = new List<FullFields>();
        //    string sqlFilterFromPR = prSel == "все" ? "" : prSel == "на производство" ? "AND IsTechnology = 1" : "AND IsTechnology = 0";
        //    using (SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}"))
        //    {
        //        db.Open();
        //        string SQLtxt = "SELECT Period, Kvart, IdCC, CCName, IsCCMain, IsCCTechnology, "
        //                        + "IdER, ERName, ERShortName, IsERMain, IsERPrime, UnitName, "
        //                        + "IdProduct, ProductName, "
        //                        + "SUM(Fact) as Fact, SUM(Plan) as Plan, SUM(Diff) as Diff, SUM(FactCost) as FactCost, "
        //                        + "SUM(PlanCost) as PlanCost, SUM(DiffCost) as DiffCost, "
        //                        + "IsNorm, IsTechnology, Produced "
        //                        + "FROM UseAllCosts WHERE NOT(IdCC == 56 AND IdER == 966) "
        //                        + "AND Period IN " + Global.ListToSting(dateSel) + " "
        //                        + "AND IdCC IN " + Global.ListToSting(ccSel) + " "
        //                        + "AND IdER IN " + Global.ListToSting(erSel) + " "
        //                        + sqlFilterFromPR + " "
        //                        + "GROUP BY Period "
        //                        + "ORDER BY Period";
        //        SqliteCommand selectCommand = new SqliteCommand(SQLtxt, db);

        //        SqliteDataReader q = selectCommand.ExecuteReader();
        //        while (q.Read())
        //        {
        //            FullFields r = new FullFields();
        //            r.Period = q.GetInt32(0);
        //            r.Year = r.Period / 100;
        //            r.Month = r.Period - r.Year * 100;
        //            r.PeriodStr = r.Year + "_" + (r.Month < 10 ? "0" + r.Month : r.Month);
        //            //r.Kvart = q.GetInt32(1);
        //            //r.Season = r.Kvart <= 2 ? 1 : 2;
        //            //r.IdCC = q.GetInt32(2);
        //            //r.CCName = q.GetString(3);
        //            //r.IsCCMain = q.GetBoolean(4);
        //            //r.IsCCTechnology = q.GetBoolean(5);
        //            r.IdER = q.GetInt32(6);
        //            r.ERName = q.GetString(7);
        //            r.ERShortName = q.GetString(8);
        //            r.IsERMain = q.GetBoolean(9);
        //            r.IsERPrime = q.GetBoolean(10);
        //            r.UnitName = q.GetString(11);
        //            //r.IdProduct = q.GetInt32(12);
        //            //r.ProductName = q.GetString(13);
        //            r.Fact = q.GetDouble(14);
        //            r.Plan = q.GetDouble(15);
        //            r.Diff = q.GetDouble(16);
        //            r.FactCost = q.GetDouble(17);
        //            r.PlanCost = q.GetDouble(18);
        //            r.DiffCost = q.GetDouble(19);
        //            r.DiffProc = r.Plan > 0 ? r.Diff * 100 / r.Plan : 0;
        //            r.IsNorm = q.GetBoolean(20);
        //            //r.Produced = q.GetDouble(22);
        //            rez.Add(r);
        //        }
        //    }
        //    return rez;
        //}
        //public static List<FullFields> RetUseDayFromER(List<Person> ccSel, List<Person> erSel)
        //{
        //    List<FullFields> rez = new List<FullFields>();
        //    using (SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}"))
        //    {
        //        db.Open();
        //        string SQLtxt = "SELECT Period, IdCC, CCName, IsCCMain, IsTechnology, "
        //                        + "IdER, ERName, IsERMain, IsERPrime, UnitName, "
        //                        + "SUM(Fact) as Fact, SUM(Plan) as Plan, SUM(Diff) as Diff, SUM(FactCost) as FactCost, SUM(PlanCost) as PlanCost, SUM(DiffCost) as DiffCost "
        //                        + "FROM CurrentUseAllCosts WHERE NOT(IdCC == 56 AND IdER == 966) "
        //                        + "AND IdCC IN " + Global.ListToSting(ccSel) + " "
        //                        + "AND IdER IN " + Global.ListToSting(erSel) + " "
        //                        + "GROUP BY IdER "
        //                        + "ORDER BY IdER";
        //        SqliteCommand selectCommand = new SqliteCommand(SQLtxt, db);

        //        SqliteDataReader q = selectCommand.ExecuteReader();
        //        while (q.Read())
        //        {
        //            FullFields r = new FullFields();
        //            r.IdER = q.GetInt32(5);
        //            r.ERName = q.GetString(6);
        //            r.IsERMain = q.GetBoolean(7);
        //            r.IsERPrime = q.GetBoolean(8);
        //            r.UnitName = q.GetString(9);
        //            r.Fact = q.GetDouble(10);
        //            r.Plan = q.GetDouble(11);
        //            r.Diff = q.GetDouble(12);
        //            r.FactCost = q.GetDouble(13);
        //            r.PlanCost = q.GetDouble(14);
        //            r.DiffCost = q.GetDouble(15);
        //            r.DiffProc = r.Plan > 0 ? r.Diff * 100 / r.Plan : 0;
        //            rez.Add(r);
        //        }
        //    }
        //    return rez;
        //}
        //public static List<FullFields> RetUseDayFromCC(List<Person> ccSel, List<Person> erSel)
        //{
        //    List<FullFields> rez = new List<FullFields>();
        //    using (SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}"))
        //    {
        //        //string aaa = Global.ListToSting(ccSel);
        //        db.Open();
        //        string SQLtxt = "SELECT Period, IdCC, CCName, IsCCMain, IsTechnology, "
        //                        + "IdER, ERName, IsERMain, IsERPrime, UnitName, "
        //                        + "SUM(Fact) as Fact, SUM(Plan) as Plan, SUM(Diff) as Diff, SUM(FactCost) as FactCost, SUM(PlanCost) as PlanCost, SUM(DiffCost) as DiffCost "
        //                        + "FROM CurrentUseAllCosts WHERE NOT(IdCC == 56 AND IdER == 966) "
        //                        + "AND IdCC IN " + Global.ListToSting(ccSel) + " "
        //                        + "AND IdER IN " + Global.ListToSting(erSel) + " "
        //                        + "GROUP BY IdCC "
        //                        + "ORDER BY IdER";
        //        SqliteCommand selectCommand = new SqliteCommand(SQLtxt, db);

        //        SqliteDataReader q = selectCommand.ExecuteReader();
        //        while (q.Read())
        //        {
        //            FullFields r = new FullFields();
        //            r.IdCC = q.GetInt32(1);
        //            r.CCName = q.GetString(2);
        //            r.IsCCMain = q.GetBoolean(3);
        //            r.IsCCTechnology = q.GetBoolean(4);
        //            r.IdER = q.GetInt32(5);
        //            r.ERName = q.GetString(6);
        //            r.IsERMain = q.GetBoolean(7);
        //            r.IsERPrime = q.GetBoolean(8);
        //            r.UnitName = q.GetString(9);
        //            r.Fact = q.GetDouble(10);
        //            r.Plan = q.GetDouble(11);
        //            r.Diff = q.GetDouble(12);
        //            r.FactCost = q.GetDouble(13);
        //            r.PlanCost = q.GetDouble(14);
        //            r.DiffCost = q.GetDouble(15);
        //            r.DiffProc = r.Plan > 0 ? r.Diff * 100 / r.Plan : 0;
        //            rez.Add(r);
        //        }
        //    }
        //    return rez;
        //}
        //public static List<FullFields> RetUseCompare(ChartDataType argType, List<Person> dateSel, List<Person> ccSel, List<Person> erSel, string prSel)
        //{
        //    string sqlFilterFromPR = prSel == "все" ? "" : prSel == "на производство" ? "AND IsTechnology = 1" : "AND IsTechnology = 0";
        //    string arg = default;
        //    if (argType == ChartDataType.ER) arg = "IdER";
        //    else if (argType == ChartDataType.CC) arg = "IdCC";
        //    else if (argType == ChartDataType.Period) arg = "Period";
        //    List<FullFields> currList = new();
        //    List<FullFields> prevList = new();
        //    List<Person> datePrev = new();
        //    foreach (Person r in dateSel)
        //    {
        //        int curPeriod = r.Id;
        //        if (curPeriod <= Period.FirstPeriod) return null;
        //        int curYear = curPeriod / 100;
        //        int prevYear = curYear - 1;
        //        int curMonth = curPeriod - curYear * 100;
        //        int prevPeriod = prevYear * 100 + curMonth;
        //        Person n = new();
        //        n.Id = prevPeriod;
        //        datePrev.Add(n);
        //    }
        //    List<FullFields> rez = new List<FullFields>();
        //    using (SqliteConnection db = new SqliteConnection($"Filename={Global.dbpath}"))
        //    {
        //        db.Open();
        //        string SQLtxt =
        //            "SELECT s.Period, s.IdCC, s.CCName, s.IdER, s.ERName, s.UnitName, SUM(s.dLimit) as dLimit, SUM(s.dNorm) as dNorm, SUM(s.dFact) as dFact, "
        //            + "SUM(s.dLimitCost) as dLimitCost, SUM(s.dNormCost) as dNormCost, SUM(s.dSumCost) as dSumCost "
        //            + "FROM "
        //            + "(SELECT  c.Period as Period, c.IdCC as IdCC, c.CCName as CCName, c.IdER as IdER, c.ERName as ERName, c.UnitName as UnitName, c.IsNorm as IsNorm, "
        //            + "ROUND(SUM(CASE WHEN c.IsNorm = 0 THEN c.Fact - p.Fact ELSE 0 END), 0) as dLimit, "
        //            + "ROUND(SUM(CASE WHEN c.IsNorm = 1 THEN c.Fact - p.Fact / p.Produced * c.Produced ELSE 0 END), 0) as dNorm, "
        //            + "ROUND((SUM(CASE WHEN c.IsNorm = 0 THEN c.Fact - p.Fact ELSE 0 END) + SUM(CASE WHEN c.IsNorm = 1 THEN c.Fact - p.Fact / p.Produced * c.Produced ELSE 0 END)), 0) as dFact, "
        //            + "ROUND(SUM(CASE WHEN c.IsNorm = 0 THEN c.FactCost - p.FactCost ELSE 0 END), 0) as dLimitCost, "
        //            + "ROUND(SUM(CASE WHEN c.IsNorm = 1 THEN c.FactCost - p.FactCost / p.Produced * c.Produced ELSE 0 END), 0) as dNormCost, "
        //            + "ROUND((SUM(CASE WHEN c.IsNorm = 0 THEN c.FactCost - p.FactCost ELSE 0 END) + SUM(CASE WHEN c.IsNorm = 1 THEN c.FactCost - p.FactCost / p.Produced * c.Produced ELSE 0 END)), 0) as dSumCost "
        //            + "FROM "
        //            + "(SELECT "
        //            + "   Period, (Period / 100) as Year, (Period - ((Period / 100) * 100)) as Month, "
        //            + "   IdCC, CCName, IdER, ERName, UnitName, IdProduct, "
        //            + "   SUM(Fact) as Fact, SUM(FactCost) as FactCost, SUM(Produced) as Produced, IsNorm "
        //            + "FROM UseAllCosts "
        //            + "WHERE "
        //            + "   NOT(IdCC == 56 AND IdER == 966) "
        //            + "   AND Period IN" + Global.ListToSting(dateSel) + " "
        //            + "   AND IdCC IN" + Global.ListToSting(ccSel) + " "
        //            + "   AND IdER IN" + Global.ListToSting(erSel) + " "
        //            + sqlFilterFromPR + " "
        //            + "GROUP BY Period, IdCC, IdER, IdProduct) c "
        //            + "JOIN "
        //            + "(SELECT "
        //            + "   Period, (Period / 100) as Year, (Period - ((Period / 100) * 100)) as Month, "
        //            + "   IdCC, CCName, IdER, ERName, UnitName, IdProduct, "
        //            + "   SUM(Fact) as Fact, SUM(FactCost) as FactCost, SUM(Produced) as Produced, IsNorm "
        //            + "FROM UseAllCosts "
        //            + "WHERE "
        //            + "   NOT(IdCC == 56 AND IdER == 966) "
        //            + "   AND Period IN" + Global.ListToSting(datePrev) + " "
        //            + "   AND IdCC IN" + Global.ListToSting(ccSel) + " "
        //            + "   AND IdER IN" + Global.ListToSting(erSel) + " "
        //            + sqlFilterFromPR + " "
        //            + "GROUP BY Period, IdCC, IdER, IdProduct) p "
        //            + "ON c.Year = p.Year + 1 AND c.Month = p.Month AND c.IdCC = p.IdCC AND c.IdER = p.IdER AND c.IdProduct = p.IdProduct "
        //            + "GROUP BY c.Period, c.IdCC, c.IdER) s "
        //            + "GROUP BY s." + arg;

        //        SqliteCommand selectCommand = new SqliteCommand(SQLtxt, db);

        //        SqliteDataReader q = selectCommand.ExecuteReader();
        //        while (q.Read())
        //        {
        //            FullFields r = new FullFields();
        //            r.Period = q.GetInt32(0);
        //            r.Year = r.Period / 100;
        //            r.Month = r.Period - r.Year * 100;
        //            r.PeriodStr = r.Year + "_" + (r.Month < 10 ? "0" + r.Month : r.Month);
        //            //r.Kvart = q.GetInt32(1);
        //            //r.Season = r.Kvart <= 2 ? 1 : 2;
        //            r.IdCC = q.GetInt32(1);
        //            r.CCName = q.GetString(2);
        //            //r.IsCCMain = q.GetBoolean(4);
        //            //r.IsCCTechnology = q.GetBoolean(5);
        //            r.IdER = q.GetInt32(3);
        //            r.ERName = q.GetString(4);
        //            //r.ERShortName = q.GetString(8);
        //            //r.IsERMain = q.GetBoolean(9);
        //            //r.IsERPrime = q.GetBoolean(10);
        //            r.UnitName = q.GetString(5);
        //            //r.IdProduct = q.GetInt32(12);
        //            //r.ProductName = q.GetString(13);
        //            //r.Fact = q.GetDouble(14);
        //            //r.Plan = q.GetDouble(15);
        //            //r.Diff = q.GetDouble(16);
        //            r.dFactLimit = q.GetDouble(6);
        //            r.dFactNormative = q.GetDouble(7);
        //            r.dFact = q.GetDouble(8);
        //            r.dFactLimitCost = q.GetDouble(9);
        //            r.dFactNormativeCost = q.GetDouble(10);
        //            r.dFactCost = q.GetDouble(11);
        //            //r.DiffProc = r.Plan > 0 ? r.Diff * 100 / r.Plan : 0;
        //            //r.IsNorm = q.GetBoolean(20);
        //            //r.Produced = q.GetDouble(22);
        //            rez.Add(r);
        //        }
        //    }
        //    return rez;

        //}

    }
}
