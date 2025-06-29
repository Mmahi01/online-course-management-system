using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCMS.Model
{
    public class Contents
    {
        SqlDBAccess sdba = new SqlDBAccess();

        public void AddContent(Content content)
        {
            SqlCommand cmd = sdba.GetQuery("INSERT INTO CourseContent (CourseID, ContentTitle, Content, UploadDate) VALUES (@CourseID, @Title, @Content, @UploadDate)");
            cmd.Parameters.AddWithValue("@CourseID", content.CourseId);
            cmd.Parameters.AddWithValue("@Title", content.ContentTitle);
            cmd.Parameters.AddWithValue("@Content", content.ContentText);
            cmd.Parameters.AddWithValue("@UploadDate", content.UploadDate);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public List<Content> GetContentByCourseId(int courseId)
        {
            SqlCommand cmd = sdba.GetQuery("SELECT * FROM CourseContent WHERE CourseID = @CourseID");
            cmd.Parameters.AddWithValue("@CourseID", courseId);

            List<Content> list = new List<Content>();
            cmd.Connection.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Content c = new Content
                {
                    ContentId = rdr.GetInt32(0),
                    CourseId = rdr.GetInt32(1),
                    ContentTitle = rdr.GetString(2),
                    ContentText = rdr.GetString(3),
                    UploadDate = rdr.GetDateTime(4)
                };
                list.Add(c);
            }
            rdr.Close();
            cmd.Connection.Close();
            return list;
        }

    }
}
