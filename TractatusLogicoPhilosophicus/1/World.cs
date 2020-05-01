// ReSharper disable All

using TractatusLogicoPhilosophicus._0;
using TractatusLogicoPhilosophicus._2;

namespace TractatusLogicoPhilosophicus
{
    /*
        2.061 Atomic facts are independent of one another.
    */
    
    /// <summary>
    /// 1 The world is everything that is the case.
    /// <para/>
    /// 1.1 The world is the totality of facts, not of things.
    /// <para/>
    /// 1.11 The world is determined by the facts, and by these being all the facts.
    /// <para/>
    /// 1.13 The facts in logical space are the world.
    /// <para/>
    /// 1.2 The world divides into facts.
    /// <para/>
    /// 2.06 The existence and non-existence of atomic facts is the reality.
    /// </summary>
    public class World
    {
        /// <summary>
        /// 1.1 The world is the totality of facts, not of things.
        /// <para/>
        /// 1.11 The world is determined by the facts, and by these being all the facts.
        /// <para/>
        /// 1.13 The facts in logical space are the world.
        /// <para/>
        /// 1.2 The world divides into facts.
        /// <para/>
        /// 1.21 Any one can either be the case or not be the case, and everything
        /// else remain the same.
        /// <para/>
        /// 2.04 The totality of existent atomic facts is the world.
        /// </summary>
        public Set<AtomicFact> Cases;

        /// <summary>
        /// 2.021 Objects form the substance of the world. Therefore they cannot
        /// be compound.
        /// <para/>
        /// 2.0211 If the world had no substance, then whether a proposition had
        /// sense would depend on whether another proposition was true.
        /// <para/>
        /// 2.0212 It would then be impossible to form a picture of the world (true or false).
        /// <para/>
        /// 2.022 It is clear that however different from the real one an imagined
        /// world may be, it must have something—a form—in common
        /// with the real world.
        /// <para/>
        /// 2.023 This fixed form consists of the objects.
        /// <para/>
        /// 2.0231 The substance of the world can only determine a form and not
        /// any material properties. For these are first presented by the
        /// propositions—first formed by the configuration of the objects.
        /// <para/>
        /// 2.0232 Roughly speaking: objects are colourless.
        /// <para/>
        /// 2.0233 Two objects of the same logical form are—apart from their external
        /// properties—only differentiated from one another in that
        /// they are different.
        /// <para/>
        /// 2.02331 Either a thing has properties which no other has, and then one
        /// can distinguish it straight away from the others by a description
        /// and refer to it; or, on the other hand, there are several things
        /// which have the totality of their properties in common, and then
        /// it is quite impossible to point to any one of them.
        /// For if a thing is not distinguished by anything, I cannot distinguish
        /// it—for otherwise it would be distinguished.
        /// <para/>
        /// 2.024 Substance is what exists independently of what is the case.
        /// <para/>
        /// 2.025 It is form and content.
        /// <para/>
        /// 2.0251 Space, time and colour (colouredness) are forms of objects.
        /// <para/>
        /// 2.026 Only if there are objects can there be a fixed form of the world.
        /// </summary>
        public WorldSubstance Substance;
        
        public World()
        {
            Substance = new WorldSubstance();
            Cases = new Set<AtomicFact>();
            
            // 2 What is the case, the fact, is the existence of atomic facts.
            Cases.Add(new AtomicFact(new AtomicFactStructure("Atomic facts exists")));
        }
        
        /// <summary>
        /// 1.12 For the totality of facts determines both what is the case, and
        /// also all that is not the case.
        /// <para/>
        /// 2.05 The totality of existent atomic facts also determines which atomic facts do not exist.
        /// </summary>
        public bool IsTheCase(AtomicFact fact)
        {
            return Cases.Contains(fact);
        }

        /// <summary>
        /// 1.21 Any one can either be the case or not be the case, and everything
        /// else remain the same.
        /// </summary>
        public void DefineAsNotTheCase(AtomicFact fact)
        {
            Cases.Remove(fact);
        }

        /// <summary>
        /// 1.21 Any one can either be the case or not be the case, and everything
        /// else remain the same.
        /// </summary>
        public void DefineAsTheCase(AtomicFact fact)
        {
            Cases.Add(fact);
        }

        /// <summary>
        /// 2.0124 If all objects are given, then thereby are all possible atomic facts also given.
        /// </summary>
        public static World DefineByAllSubjects(Set<Entity> subjects)
        {
            var world = new World();
            
            subjects.ForEach(subject => 
                subject.Cases.ForEach(fact => 
                    world.DefineAsTheCase(fact)));
            
            return world;
        }
    }
}