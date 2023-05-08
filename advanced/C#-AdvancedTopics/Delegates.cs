
namespace C__AdvancedTopics
{
    //a Delegate is an object that know how to call a method or a group of mehtods
    //it's a reference to a function

    //could be used in the place of a interface

    //helps making flexible and extensible applications (eg frameworks)
    class Delegates
    {
        //.NET EXISTING DELEGATES
        //System.Action<> //points to a method that returns void
        //System.Func<> //points to a method that returns a value
    }

    //CUSTOM DELEGATES
    class Program
    {

    static void Main(string[] args)
    {
        var processor = new PhotoProcessor();
        var filters = new PhotoFilters();
        //the filters have been defined in the PhotoFilters class
        //and this is a pointer to the method we want to use (Brightness in this case)
        PhotoProcessor.PhotoFilterHandler filterHandler = filters.Brightness;
        filterHandler += filters.Contrast; //add another filter to the handler (pointer to another method)
        filterHandler += RemoveRedEyeFilter;

        processor.Process("photo.jpg", filterHandler);
        //this will apply brightness to the photo
        //and contrast
        //and remove red eye
    }

        //create a new filter
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("remove red eye");
        }
    }

    public class PhotoProcessor
    {

        //define a delegate type
        //an instance of this delegate can hold a pointer to a function or group of functions
        public delegate void PhotoFilterHandler(Photo photo);
         

        //this Process method could be written using an already existing delegate
        //public void Process(string path, Action<Photo> filterHandler)
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.load(path);

            //var filters = new PhotoFilters();
            //filters.Brightness(photo);
            //filters.Contrast(photo);
            //filters.resize(photo);

            filterHandler(photo);

            photo.Save();
        }
    }

    //Photo classes
    //apply some filters, load and save a photo
    public class Photo
    {
        public static Photo load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }

    public class PhotoFilters
    {
        public PhotoFilters()
        {
        }

        public void Brightness(Photo photo)
        {
            Console.WriteLine("added brightness to photo");
        }
        public void Contrast(Photo photo)
        {
            Console.WriteLine("added contrast to photo");
        }
        public void resize(Photo photo)
        {
            Console.WriteLine("resized photo");
        }
    }
}
