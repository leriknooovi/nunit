namespace Groups.Implementions;

public class SubjectEntity
{
    public string Name { get; set; }
    public List<TeacherEntity> Teachers { get; set; }

    public SubjectEntity(string name)
    {
        Name = name;
        Teachers = new List<TeacherEntity>();
    }

    public void AddTeacher(TeacherEntity teacher)
    {
        Teachers.Add(teacher);
    }
}