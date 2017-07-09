using D2D.EntityFrameworkCore;
using D2D.Tasks;

namespace D2D.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly D2DDbContext _context;

        public TestDataBuilder(D2DDbContext context)
        {
            _context = context;
        }

        /*public void Build()
        {
            var neo = new Person("Neo");
            _context.People.Add(neo);
            _context.SaveChanges();

            _context.Tasks.AddRange(
                new Task("Follow the white rabbit", "Follow the white rabbit in order to know the reality.", neo.Id),
                new Task("Clean your room") { State = TaskState.Completed }
            );
        }*/

        public void Build()
        {
            _context.Tasks.AddRange(
                new Task("Follow the white rabbit", "Follow the white rabbit in order to know the reality."),
                new Task("Clean your room") { State = TaskState.Completed }
            );
        }
    }
}