using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDB
{
    public class BirdData
    {
        private const string connectString = @"Data Source=DESKTOP-VI36M1G\SQLEXPRESS;Initial Catalog = Birds;Integrated Security=SSPI";
        private const string sqlErrorMessage = "Database operation failed.  Please contact your System Administrator.";

        public static DataSet GetBirdInfo()
        {
            try
            {
                SqlDataAdapter birdDataAdapter = new SqlDataAdapter();
                DataSet birdsDataSet = new DataSet();
                birdDataAdapter.SelectCommand = new SqlCommand();
                birdDataAdapter.SelectCommand.CommandText = "Select * from BirdCount order by CountID";
                birdDataAdapter.SelectCommand.Connection = new SqlConnection();
                birdDataAdapter.SelectCommand.Connection.ConnectionString = connectString;
                birdDataAdapter.Fill(birdsDataSet, "BirdInfo");

                //// load DataSet with 2nd table used for ForeignKeyConstraint
                //birdDataAdapter.SelectCommand.CommandText =
                // "Select * from Bird";
                //birdDataAdapter.Fill(birdsDataSet, "Bird");

                ////==========================================================
                //ForeignKeyConstraint birdidFKeyConstraint;
                //birdidFKeyConstraint = new ForeignKeyConstraint("BirdID-FK",
                //    birdsDataSet.Tables["Bird"].Columns["BirdID"],
                //    birdsDataSet.Tables["BirdInfo"].Columns["BirdID"]);
                //    //birdidFKeyConstraint.UpdateRule = Rule.None;
                //    //birdidFKeyConstraint.AcceptRejectRule = AcceptRejectRule.Cascade;
                //birdsDataSet.Tables["BirdInfo"].Constraints.Add(birdidFKeyConstraint);
                //birdsDataSet.EnforceConstraints = true;

                return birdsDataSet;
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException(sqlErrorMessage);
            }
        }

        public static int SaveBirdInfo(DataSet birdDataSet)
        {
            SqlDataAdapter birdDataAdapter = new SqlDataAdapter();
            birdDataAdapter.UpdateCommand = new SqlCommand();

            //Update Commands
            birdDataAdapter.UpdateCommand.Connection = new SqlConnection();
            birdDataAdapter.UpdateCommand.Connection.ConnectionString = connectString;
            birdDataAdapter.UpdateCommand.CommandText =
                " UPDATE BirdCount SET RegionID = @RegionID, BirderID =@BirderID, BirdID= @BirdID, " +
                " CountDate=@CountDate, Count=@Count WHERE CountID = @CountID";

            //Insert Commands
            birdDataAdapter.InsertCommand = new SqlCommand();
            birdDataAdapter.InsertCommand.CommandText =
                "INSERT into BirdCount" +
                "(RegionID, BirderID, BirdID, CountDate, Count)" +
                "VALUES (@RegionID, @BirderID, @BirdID, @CountDate, @Count)";

            //Insert Parameters
            birdDataAdapter.InsertCommand.Parameters.Add("@RegionID", System.Data.SqlDbType.Int);
            birdDataAdapter.InsertCommand.Parameters["@RegionID"].SourceColumn = "RegionID";

            birdDataAdapter.InsertCommand.Parameters.Add("@BirderID", System.Data.SqlDbType.Int);
            birdDataAdapter.InsertCommand.Parameters["@BirderID"].SourceColumn = "BirderID";

            birdDataAdapter.InsertCommand.Parameters.Add("@BirdID", System.Data.SqlDbType.Int);
            birdDataAdapter.InsertCommand.Parameters["@BirdID"].SourceColumn = "BirdID";

            birdDataAdapter.InsertCommand.Parameters.Add("@CountDate", System.Data.SqlDbType.Date);
            birdDataAdapter.InsertCommand.Parameters["@CountDate"].SourceColumn = "CountDate";

            birdDataAdapter.InsertCommand.Parameters.Add("@Count", System.Data.SqlDbType.Int);
            birdDataAdapter.InsertCommand.Parameters["@Count"].SourceColumn = "Count";

            //Update Parameters
            birdDataAdapter.UpdateCommand.Parameters.Add("@CountID", System.Data.SqlDbType.Int);
            birdDataAdapter.UpdateCommand.Parameters["@CountID"].SourceColumn = "CountID";

            birdDataAdapter.UpdateCommand.Parameters.Add("@RegionID", System.Data.SqlDbType.Int);
            birdDataAdapter.UpdateCommand.Parameters["@RegionID"].SourceColumn = "RegionID";

            birdDataAdapter.UpdateCommand.Parameters.Add("@BirderID", System.Data.SqlDbType.Int);
            birdDataAdapter.UpdateCommand.Parameters["@BirderID"].SourceColumn = "BirderID";

            birdDataAdapter.UpdateCommand.Parameters.Add("@BirdID", System.Data.SqlDbType.Int);
            birdDataAdapter.UpdateCommand.Parameters["@BirdID"].SourceColumn = "BirdID";

            birdDataAdapter.UpdateCommand.Parameters.Add("@CountDate", System.Data.SqlDbType.Date);
            birdDataAdapter.UpdateCommand.Parameters["@CountDate"].SourceColumn = "CountDate";

            birdDataAdapter.UpdateCommand.Parameters.Add("@Count", System.Data.SqlDbType.Int);
            birdDataAdapter.UpdateCommand.Parameters["@Count"].SourceColumn = "Count";


            birdDataAdapter.InsertCommand.Connection = birdDataAdapter.UpdateCommand.Connection;
            birdDataAdapter.UpdateCommand.Connection.Open();

            //Use the DataAdapter to update the database
            int rowCount = birdDataAdapter.Update(birdDataSet, "BirdInfo");

            return rowCount;
        }
    }
}
