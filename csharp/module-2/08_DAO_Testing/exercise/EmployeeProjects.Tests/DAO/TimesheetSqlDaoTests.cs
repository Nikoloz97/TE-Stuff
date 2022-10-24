using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using EmployeeProjects.DAO;
using EmployeeProjects.Models;

namespace EmployeeProjects.Tests.DAO
{
    [TestClass]
    public class TimesheetSqlDaoTests : BaseDaoTests
    {
        private static readonly Timesheet TIMESHEET_1 = new Timesheet(1, 1, 1, DateTime.Parse("2021-01-01"), 1.0M, true, "Timesheet 1");
        private static readonly Timesheet TIMESHEET_2 = new Timesheet(2, 1, 1, DateTime.Parse("2021-01-02"), 1.5M, true, "Timesheet 2");
        private static readonly Timesheet TIMESHEET_3 = new Timesheet(3, 2, 1, DateTime.Parse("2021-01-01"), 0.25M, true, "Timesheet 3");
        private static readonly Timesheet TIMESHEET_4 = new Timesheet(4, 2, 2, DateTime.Parse("2021-02-01"), 2.0M, false, "Timesheet 4");

        private TimesheetSqlDao dao;


        [TestInitialize]
        public override void Setup()
        {
            dao = new TimesheetSqlDao(ConnectionString);
            base.Setup();
        }

        [TestMethod]
        public void GetTimesheet_ReturnsCorrectTimesheetForId()
        {
            Timesheet timesheet = dao.GetTimesheet(1);
            AssertTimesheetsMatch(TIMESHEET_1, timesheet);
        }

        [TestMethod]
        public void GetTimesheet_ReturnsNullWhenIdNotFound()
        {
            Timesheet timesheet = dao.GetTimesheet(5);
            Assert.IsNull(timesheet);
        }

        [TestMethod]
        public void GetTimesheetsByEmployeeId_ReturnsListOfAllTimesheetsForEmployee()
        {
            IList <Timesheet> actualList = dao.GetTimesheetsByEmployeeId(2);

            IList<Timesheet> expectedList = new List<Timesheet>();
            expectedList.Add(TIMESHEET_4);

            Assert.AreEqual(expectedList.Count, actualList.Count);

        }

        [TestMethod]
        public void GetTimesheetsByProjectId_ReturnsListOfAllTimesheetsForProject()
        {
            IList<Timesheet> actualList = dao.GetTimesheetsByProjectId(1);

            IList<Timesheet> expectedList = new List<Timesheet>();
            expectedList.Add(TIMESHEET_1);
            expectedList.Add(TIMESHEET_2);
            expectedList.Add(TIMESHEET_3);


            Assert.AreEqual(expectedList.Count, actualList.Count);
        }

        [TestMethod]
        public void CreateTimesheet_ReturnsTimesheetWithIdAndExpectedValues()
        {

            Timesheet newTimeSheet = new Timesheet(0, 2, 2, DateTime.Parse("2021-01-01"), 1.0M, true, "Timesheet 5");
            Timesheet timesheet = dao.CreateTimesheet(newTimeSheet);

            Assert.IsTrue(timesheet.TimesheetId > 0);

            newTimeSheet.TimesheetId = timesheet.TimesheetId;
            AssertTimesheetsMatch(newTimeSheet, timesheet);

        }

        [TestMethod]
        public void CreatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Timesheet newTimeSheet = new Timesheet(0, 2, 2, DateTime.Parse("2021-01-01"), 1.0M, true, "Timesheet 5");
            Timesheet timesheet = dao.CreateTimesheet(newTimeSheet);

            newTimeSheet.TimesheetId = timesheet.TimesheetId;

            Timesheet retrievedTimesheet = dao.GetTimesheet(timesheet.TimesheetId);

            AssertTimesheetsMatch(newTimeSheet, retrievedTimesheet);

        }

        [TestMethod]
        public void UpdatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Timesheet timesheetToUpdate = dao.GetTimesheet(2);

            timesheetToUpdate.IsBillable = true;
            dao.UpdateTimesheet(timesheetToUpdate);

            Timesheet retrievedTimesheet = dao.GetTimesheet(2);

            AssertTimesheetsMatch(timesheetToUpdate, retrievedTimesheet);

        }

        [TestMethod]
        public void DeletedTimesheetCantBeRetrieved()
        {
            dao.DeleteTimesheet(3);

            Timesheet retrivedTimeSheet = dao.GetTimesheet(3);

            Assert.IsNull(retrivedTimeSheet);
        }

        [TestMethod]
        public void GetBillableHours_ReturnsCorrectTotal()
        {
            decimal billableHours = dao.GetBillableHours(1, 1);

            Assert.AreEqual(2.5M, billableHours);
        }

        private void AssertTimesheetsMatch(Timesheet expected, Timesheet actual)
        {
            Assert.AreEqual(expected.TimesheetId, actual.TimesheetId);
            Assert.AreEqual(expected.EmployeeId, actual.EmployeeId);
            Assert.AreEqual(expected.ProjectId, actual.ProjectId);
            Assert.AreEqual(expected.DateWorked, actual.DateWorked);
            Assert.AreEqual(expected.HoursWorked, actual.HoursWorked);
            Assert.AreEqual(expected.IsBillable, actual.IsBillable);
            Assert.AreEqual(expected.Description, actual.Description);
        }
    }
}
