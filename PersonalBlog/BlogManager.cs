using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBlog
{
    public class BlogManager
    {
        private List<BlogPost> _posts = new List<BlogPost>();
        private int _nextId = 1;

        public void AddPost(string title, string content)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("Заголовок не може бути порожнім.");

            _posts.Add(new BlogPost
            {
                Id = _nextId++,
                Title = title,
                Content = content
            });
        }

        public List<BlogPost> GetAllPosts() => _posts;

        public bool DeletePost(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post != null)
            {
                return _posts.Remove(post);
            }
            return false;
        }

        public int GetCount() => _posts.Count;
    }
}
