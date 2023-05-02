using MediaCollection.MediaFiles;

namespace MediaCollection
{
    public class Program
    {
        List<File> files;

        public void Main()
        {
            files = new List<File>();

            files.Add(new Text());
            
            Folder newFolder = new Folder();
            newFolder.Files.Add(new Image());
            newFolder.Files.Add(new Video());
            
            files.Add(newFolder);
        }
    }
}