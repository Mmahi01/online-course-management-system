using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCMS.Model
{
    public class Content
    {
        private int contentId;
        private int courseId;
        private string contentTitle;
        private string contentText;
        private DateTime uploadDate;


        public int ContentId { get { return contentId; } set { contentId = value; } }
        public int CourseId { get { return courseId; } set { courseId = value; } }
        public string ContentTitle { get { return contentTitle; } set { contentTitle = value; } }
        public string ContentText { get { return contentText; } set { contentText = value; } }
        public DateTime UploadDate { get { return uploadDate; } set { uploadDate = value; } }


        public Content()
        { }

        public Content(int contentId, int courseId, string contentTitle, string contentText, DateTime uploadDate)
        {
            this.contentId = contentId;
            this.courseId = courseId;
            this.contentTitle = contentTitle;
            this.contentText = contentText;
            this.uploadDate = uploadDate;
            
            
        }
    }

}
