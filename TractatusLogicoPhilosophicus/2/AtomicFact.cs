using TractatusLogicoPhilosophicus._0;

namespace TractatusLogicoPhilosophicus._2
{
    /// <summary>
    /// 2.01 An atomic fact is a combination of objects (entities, things).
    /// </summary>
    public class AtomicFact
    {
        /// <summary>
        /// 2.01 An atomic fact is a combination of objects (entities, things).
        /// <para/>
        /// 2.03 In the atomic fact objects hang one in another, like the members of a chain.
        /// </summary>
        public Set<Entity> Entities;
        
        public AtomicFactStructure Structure;

        public AtomicFact(AtomicFactStructure structure)
        {
            Structure = structure;
        }
    }
}