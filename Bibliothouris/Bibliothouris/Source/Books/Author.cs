namespace Bibliothouris.Source.Book {
    public class Author {

        public string FirstName;
        public string LastName;


        public Author(string FirstName, string LastName) {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }

        public override bool Equals(object obj) {
            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }

            return FirstName.Equals(((Author)obj).FirstName) &&
                LastName.Equals(((Author)obj).LastName);
        }

        public override int GetHashCode() {
            return FirstName.GetHashCode() + LastName.GetHashCode();
        }
    }
}