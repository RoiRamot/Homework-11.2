using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttribDemo.Class
{
    [System.AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    public sealed class CodeReviewAttribute : Attribute
    {
        private string _reviewerName;
        private string _reviewdate;
        private bool _isAprroved;

        public CodeReviewAttribute(string reviewerName)
        {
            _reviewerName = reviewerName;
        }

        public CodeReviewAttribute(string reviewerName, string reviewdate)
        {
            _reviewdate = reviewdate;
            _reviewerName = reviewerName;
        }

        public CodeReviewAttribute(string reviewerName, string reviewdate, bool isAprroved)
        {
            _reviewerName = reviewerName;
            _isAprroved = isAprroved;
            _reviewdate = reviewdate;
        }

        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
           sb.Append(_reviewerName);
           sb.Append("  ");
           sb.Append(_reviewdate);
           sb.Append("  ");
           sb.Append(_isAprroved);
            return sb.ToString();
        }
    }
}
