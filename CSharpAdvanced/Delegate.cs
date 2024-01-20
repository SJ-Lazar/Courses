public class Delegate
{
    //What is a delegate?
    //A delegate is a type that represents references to methods with a particular parameter list and return type.
    //When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.
    //You can invoke (or call) the method through the delegate instance.

    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo); //pointer to a function

        //Exsiting delegate
        //Action<Photo> or Func<Photo, int> or Predicate<Photo>
        //Action and Func are generic delegates
        //Action is a delegate that can point to a method that returns void
        //Func is a delegate that can point to a method that returns a value



        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            photo.Save();
        }
    }

    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }


    }

    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {

        }
    }
}





