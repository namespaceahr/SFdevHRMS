using Entities;
using Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class TrainingData
    {

        DataAccess da = new DataAccess();

        public bool insertTraining(Training obj)
        {
            string insertCommand = "INSERT INTO Training (trainingId,EmployeeId,topic,reviewOfTraining) " +
                                   "VALUES (@trainingId,@EmployeeId,@topic,@reviewOfTraining)";
            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter trainingIdParameter = new SqlParameter("@trainingId", SqlDbType.Int);
            trainingIdParameter.Value = obj.trainingId;

            SqlParameter idParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
            idParameter.Value = obj.employeeId;

            SqlParameter topicParameter = new SqlParameter("@topic", SqlDbType.NVarChar, 50);
            topicParameter.Value = obj.topic;
            SqlParameter reviewOfTrainingParameter = new SqlParameter("@reviewOfTraining", SqlDbType.NVarChar, 50);
            reviewOfTrainingParameter.Value = obj.reviewTraining;







            command.Parameters.Add(trainingIdParameter);
            command.Parameters.Add(idParameter);
            command.Parameters.Add(topicParameter);
            command.Parameters.Add(reviewOfTrainingParameter);

           




            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void deleteEmployeeTraining(string employeeId)
        {


            string insertCommand = "delete from Training where employeeId='" + employeeId + "'";
            SqlCommand command = new SqlCommand(insertCommand);
            da.Execution(command);

        }

        public bool updateTraining(Training obj)
        {
            string insertCommand = "update Training set topic=@topic,reviewOfTraining=@reviewOfTraining " +
                                   " where  trainingId=@trainingId and EmployeeId=@EmployeeId ";
            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter trainingIdParameter = new SqlParameter("@trainingId", SqlDbType.Int);
            trainingIdParameter.Value = obj.trainingId;

            SqlParameter idParameter = new SqlParameter("@EmployeeId", SqlDbType.NVarChar, 50);
            idParameter.Value = obj.employeeId;

            SqlParameter topicParameter = new SqlParameter("@topic", SqlDbType.NVarChar, 50);
            topicParameter.Value = obj.topic;
            SqlParameter reviewOfTrainingParameter = new SqlParameter("@reviewOfTraining", SqlDbType.NVarChar, 50);
            reviewOfTrainingParameter.Value = obj.reviewTraining;







            command.Parameters.Add(trainingIdParameter);
            command.Parameters.Add(idParameter);
            command.Parameters.Add(topicParameter);
            command.Parameters.Add(reviewOfTrainingParameter);






            if (da.Execution(command))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteTraining(Training obj)
        {
             string insertCommand = "delete from training  " +
                                   "where trainingId= @trainingId ";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter trainingIdParameter = new SqlParameter("@trainingId", SqlDbType.Int);
             trainingIdParameter.Value = obj.trainingId;


             command.Parameters.Add(trainingIdParameter);

             if (da.Execution(command))
             {
                 return true;

             }
             else
             {
                 return false;
             }
        }

        public List<object> GetEmployeeTrainingId(string eid)
        {
            List<object> tidList = new List<object>();
            string query = "select  trainingId from training  where employeeId='"+ eid +"'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


               tidList.Add(reader.GetInt32(0));
            }
            return tidList;
        }

        public Training  GetEmployeeTraininginfo(int tid)
        {
            Training t = new Training();
            string query = "select  topic,reviewOfTraining from training  where trainingId='" + tid + "'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {


                t.topic=reader.GetString(0);
                t.reviewTraining = reader.GetString(1);
            }
            return t;
        }

        public List<Training> GetEmployeeTrainingEmployee(string eid)
        {
            List<Training> tList = new List<Training>();

            string query = "select  trainingId,EmployeeId,topic,reviewOfTraining from training  where employeeId='" + eid + "'";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Training t = new Training();
                t.trainingId = reader.GetInt32(0);
                t.employeeId = reader.GetString(1);
                t.topic = reader.GetString(2);
                t.reviewTraining = reader.GetString(3);


                tList.Add(t);
            }
            return tList;
        }


        public List<Training> GetAllEmployeeTraining()
        {
            List<Training> tList = new List<Training>();

            string query = "select  trainingId,EmployeeId,topic,reviewOfTraining from training";
            SqlCommand cmd = da.GetCommand(query);
            cmd.Connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Training t = new Training();
                t.trainingId = reader.GetInt32(0);
                t.employeeId = reader.GetString(1);
                t.topic = reader.GetString(2);
                t.reviewTraining = reader.GetString(3);


                tList.Add(t);
            }
            return tList;
        }
    }
}
