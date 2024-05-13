namespace PRG521_FA2.Class
{
    /// <summary>
    /// Contains interfaces for feedable and movable objects.
    /// </summary>
    internal class Interfaces
    {
        /// <summary>
        /// Interface for objects that can be fed.
        /// </summary>
        public interface IFeedable
        {
            /// <summary>
            /// Method to feed the object.
            /// </summary>
            /// <returns>A message indicating the feeding action.</returns>
            string Feed();
        }

        /// <summary>
        /// Interface for objects that can move.
        /// </summary>
        public interface IMovable
        {
            /// <summary>
            /// Method to make the object move.
            /// </summary>
            /// <returns>A message indicating the movement action.</returns>
            string Move();
        }
    }
}
