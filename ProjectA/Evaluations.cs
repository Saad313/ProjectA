using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectA
{
    class Evaluations
    {
        public static string conStr = "Data Source=DESKTOP-EGB6CH6;Initial Catalog=ProjectA;Integrated Security=True";
        int GroupId;
        int EvalId;
        int ObtainedMarks;
        int TotalMarks;
        DateTime EvalDate;
        int TotalWeightage;
        string EvalName;

        public int GroupId1 { get => GroupId; set => GroupId = value; }
        public int EvalId1 { get => EvalId; set => EvalId = value; }
        public int ObtainedMarks1 { get => ObtainedMarks; set => ObtainedMarks = value; }
        public int TotalMarks1 { get => TotalMarks; set => TotalMarks = value; }
        public DateTime EvalDate1 { get => EvalDate; set => EvalDate = value; }
        public int TotalWeightage1 { get => TotalWeightage; set => TotalWeightage = value; }
        public string EvalName1 { get => EvalName; set => EvalName = value; }
        public static List<Evaluations> Eval = new List<Evaluations>();
        public static List<Evaluations> groupEvals = new List<Evaluations>();


        public static void ShowGroupEvals()
        {
            groupEvals.Clear();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string fetch = "SELECT GroupId, EvaluationId, ObtainedMarks, EvaluationDate, Name, TotalMarks , TotalWeightage FROM GroupEvaluation JOIN Evaluation ON Evaluation.Id = GroupEvaluation.EvaluationId";
                SqlCommand cmd = new SqlCommand(fetch, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Evaluations ge = new Evaluations();

                    ge.GroupId1 = Convert.ToInt32(reader["GroupId"]);
                    ge.EvalId1 = Convert.ToInt32(reader["EvaluationId"]);
                    ge.ObtainedMarks1 = Convert.ToInt32(reader["ObtainedMarks"]);
                    ge.EvalDate1 = Convert.ToDateTime(reader["EvaluationDate"]);
                    ge.EvalName1 = Convert.ToString(reader["Name"]);
                    ge.TotalMarks1 = Convert.ToInt32(reader["TotalMarks"]);
                    ge.TotalWeightage1 = Convert.ToInt32(reader["TotalWeightage"]);

                    groupEvals.Add(ge);
                }
            }
        }
        public static void getEvaluations()
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            Eval.Clear();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT * FROM Evaluation";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Evaluations e = new Evaluations();
                    e.EvalId1 = Convert.ToInt32(reader["Id"]);
                    e.EvalName1 = Convert.ToString(reader["Name"]);
                    e.TotalMarks1 = Convert.ToInt32(reader["TotalMarks"]);
                    e.TotalWeightage1 = Convert.ToInt32(reader["TotalWeightage"]);

                    Eval.Add(e);
                }
            }
        }
    }
}
