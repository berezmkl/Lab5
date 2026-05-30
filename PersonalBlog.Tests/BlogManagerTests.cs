using NUnit.Framework;
using PersonalBlog;
using System;

namespace PersonalBlog.Tests
{
    public class BlogManagerTests
    {
        private BlogManager _manager;

        [SetUp]
        public void Setup()
        {
            _manager = new BlogManager();
        }

        [Test]
        public void AddPost_ShouldIncreaseCount()
        {
            // Arrange
            string title = "Тестовий заголовок";
            string content = "Текст посту";

            // Act
            _manager.AddPost(title, content);

            // Assert
            Assert.That(_manager.GetCount(), Is.EqualTo(1));
        }

        [Test]
        public void AddPost_EmptyTitle_ShouldThrowException()
        {
            // Act & Assert
            Assert.That(() => _manager.AddPost("", "Контент"), Throws.ArgumentException);
        }

        [Test]
        public void DeletePost_ExistingId_ShouldReturnTrue()
        {
            // Arrange
            _manager.AddPost("Пост", "Контент");
            int idToDelete = 1;

            // Act
            bool result = _manager.DeletePost(idToDelete);

            // Assert
            Assert.That(result, Is.True);
            Assert.That(_manager.GetCount(), Is.EqualTo(0));
        }

        [Test]
        public void DeletePost_NonExistingId_ShouldReturnFalse()
        {
            // Act
            bool result = _manager.DeletePost(999);

            // Assert
            Assert.That(result, Is.False);
        }
    }
}