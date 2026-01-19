using System;

namespace CG_Practice.dsascenario.UniversityCourseManagement
{
    public interface ICourse<T> where T : CourseType
    {
        void Add(T course);
        void Show();
    }
}
