using System.IO;
using System.Text;

namespace SettingX.Core.Models
{
    public struct BlobResult
    {
        private readonly MemoryStream _stream;

        public BlobResult(MemoryStream stream)
        {
            _stream = stream;
            _stream.Position = 0;
        }

        public Stream AsStream()
        {

            return _stream;
        }

        public byte[] AsBytes()
        {
                _stream.Position = 0;
                var result = new MemoryStream();

                _stream.CopyTo(result);
                return result.ToArray();
        }

        public string AsString(Encoding encoding = null)
        {
            if (encoding == null)
                encoding = Encoding.UTF8;

            return encoding.GetString(AsBytes());
        }
    }
}
