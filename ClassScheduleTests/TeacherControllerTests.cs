using System;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using ClassSchedule.Models;
using ClassSchedule.Controllers;

namespace ClassScheduleTests
{
    public class TeacherControllerTests
    {
        [Fact]
        public void IndexActionMethode_ReturnAViewResult()
        {
            var unit = new Mock<ClassScheduleContext>();
            var controller = new TeacherController(unit.Object);

            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}
