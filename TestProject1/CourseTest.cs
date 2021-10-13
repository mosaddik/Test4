using Manager.Implementation;
using Manager.Interface;
using Models.Models;
using Moq;
using Repository.Interface;
using System;
using Xunit;

namespace TestProject1
{
    public class CourseTest
    {
        [Fact]
        public void NoEmetyCourseNameAdded()
        {
            var aCourseManager = new Mock<ICourseRepository>();

            var couseM = new CourseManager(aCourseManager.Object);

            Assert.Throws<ArgumentException>(
                    () => couseM.Create(string.Empty)
                );
        }

        [Fact]
        public void ValidSetup()
        {
            var aCourseManager = new Mock<ICourseRepository>();

            aCourseManager.Setup(p => p.Add(It.IsAny<Course>()));

            var couseM = new CourseManager(aCourseManager.Object);

            Assert.True(couseM.Create("asdasdsadsa"));
        }
    }
}
