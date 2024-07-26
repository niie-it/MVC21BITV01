namespace Lab07.Models
{
    public class MyTool
    {
        /// <summary>
        /// Upload file lên thư mục chỉ định
        /// </summary>
        /// <param name="myFile">IFormFile</param>
        /// <param name="folderName">thư mục</param>
        /// <returns></returns>
        public static string UploadImageToFolder(IFormFile myFile, string folderName)
        {
            if (myFile == null)
            {
                return string.Empty;
            }
            try
            {
                var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images", folderName, myFile.FileName);
                using (var newFile = new FileStream(fullPath, FileMode.CreateNew))
                {
                    myFile.CopyTo(newFile);
                }
                return myFile.FileName;
            }
            catch (Exception ex) { return string.Empty; }
        }
    }
}
