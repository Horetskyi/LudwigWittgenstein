namespace TractatusLogicoPhilosophicus.TODO
{
    /// <summary>
    /// 2.13. Объектам соответствуют в образе элементы этого образа. 
    /// </summary>
    public class FactImageElement
    {
        /// <summary>
        /// 2.131. Элементы образа замещают в образе объекты
        /// </summary>
        public string SubjectDescription;

        /// <summary>
        /// 2.13. Объектам соответствуют в образе элементы этого образа.
        /// <para/>
        /// 2.131. Элементы образа замещают в образе объекты
        /// </summary>
        public FactImageElement(string subjectDescription)
        {
            SubjectDescription = subjectDescription;
        }
    }
}