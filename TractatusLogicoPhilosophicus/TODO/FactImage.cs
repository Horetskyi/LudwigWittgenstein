using System;
using TractatusLogicoPhilosophicus._0;

namespace TractatusLogicoPhilosophicus.TODO
{
    /// <summary>
    /// Образ факта
    /// <para/>
    /// 2.11. Образ изображает факты в логическом пространстве,
    /// т. е. в пространстве существования или несуществования атомарных фактов.
    /// <para/>
    /// 2.12. Образ есть модель действительности.
    /// <para/>
    /// 2.141. Образ есть факт. 
    /// </summary>
    public class FactImage
    {
        /// <summary>
        /// 2.13. Объектам соответствуют в образе элементы этого образа. 
        /// </summary>
        public Set<FactImageElement> Elements;

        /// <summary>
        /// 2.14. Образ состоит в том, что его элементы соединяются друг с другом определенным способом.
        /// </summary>
        public string ConnectionWay;

        /// <summary>
        /// 2.15. То, что элементы образа соединяются друг с другом определенным способом, показывает, что так же
        /// соединяются друг с другом и вещи. Эта связь элементов образа называется его структурой,
        /// а возможность этой структуры – формой отображения этого образа.  
        /// </summary>
        public string Structure(Set<Entity> subjects)
        {
            return subjects + ConnectionWay + "as" + Elements;
        }

        /// <summary>
        /// Форма отображения образа факта
        /// <para/>
        /// 2.151. Форма отображения есть возможность того, что предметы соединены друг с другом так же, как элементы
        /// образа.
        /// <para/>
        /// 2.1511. Так образ связан с действительностью; он достает до нее.
        /// <para/>
        /// 2. 1512. Он подобен масштабу, приложенному к действительности.
        /// <para/>
        /// 2. 1513. Согласно этому взгляду, образу принадлежит также отношение отображения, которое и делает его образом. 
        /// </summary>
        public bool FactImageFormDisplay(Set<Entity> subjects, Reality reality)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 2.13. Объектам соответствуют в образе элементы этого образа.
        /// <para/>
        /// 2.131. Элементы образа замещают в образе объекты
        /// </summary>
        public FactImage(Set<FactImageElement> elements, string connectionWay)
        {
            Elements = elements;
            ConnectionWay = connectionWay;
        }
    }

    /// <summary>
    /// Действительность
    /// </summary>
    public class Reality
    {
        
    } 
}