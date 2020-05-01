using TractatusLogicoPhilosophicus._0;

namespace TractatusLogicoPhilosophicus._2
{
    /// <summary>
    /// 2.034 The structure of the fact consists of the structures of the atomic facts.
    /// </summary>
    public class ComplexFact
    {
        public Set<Entity> Entities;
        
        /// <summary>
        /// 2.034 The structure of the fact consists of the structures of the atomic facts.
        /// </summary>
        public Set<AtomicFactStructure> Structures;
    }
}