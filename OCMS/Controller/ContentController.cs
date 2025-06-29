using OCMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCMS.Controller
{
    class ContentController
    {
        Contents contentModel = new Contents();

        public void AddContent(Content content)
        {
            contentModel.AddContent(content);
        }

        public List<Content> GetContentByCourseId(int courseId)
        {
            return contentModel.GetContentByCourseId(courseId);
        }

    }
}
