// ReSharper disable All

using TractatusLogicoPhilosophicus._0;
using TractatusLogicoPhilosophicus._2;

namespace TractatusLogicoPhilosophicus
{
    /*
        2.0122 The thing is independent, in so far as it can occur in all possible
        circumstances, but this form of independence is a form of
        connexion with the atomic fact, a form of dependence. (It is
        impossible for words to occur in two different ways, alone and
        in the proposition.)
        
        2.01231 In order to know an object, I must know not its external but all
        its internal qualities.
        
        2.0271 The object is the fixed, the existent; the configuration is the
        changing, the variable.

        2.0272 The configuration of the objects forms the atomic fact.

    */
    
    /// <summary>
    /// Entity or Thing    
    /// <para/>
    /// 2.02 The object is simple.
    /// <para/>
    /// 2.021 Objects form the substance of the world. Therefore they cannot
    /// be compound.
    /// <para/>
    /// 2.027 The fixed, the existent and the object are one.
    /// </summary>
    public class Entity
    {
        /// <summary>
        /// 2.011 It is essential to a thing that it can be a constituent part of an atomic fact.
        /// <para/>
        /// 2.014 Objects contain the possibility of all states of affairs.
        /// <para/>
        /// 2.0141 The possibility of its occurrence in atomic facts is the form of
        /// the object.
        /// </summary>
        public Set<AtomicFact> Cases;

        /// <param name="cases">
        /// 2.012 In logic nothing is accidental: if a thing can occur in an atomic
        /// fact the possibility of that atomic fact must already be prejudged in the thing.
        /// <para/>
        /// 2.0121 It would, so to speak, appear as an accident, when to a thing
        /// that could exist alone on its own account, subsequently a state
        /// of affairs could be made to fit.
        /// If things can occur in atomic facts, this possibility must already lie in them.
        /// <para/>
        /// 2.0123 If I know an object, then I also know all the possibilities of its
        /// occurrence in atomic facts.
        /// (Every such possibility must lie in the nature of the object.)
        /// A new possibility cannot subsequently be found.
        /// </param>
        public Entity(Set<AtomicFact> cases)
        {
            Cases = cases;
        }
        
        /// <summary>
        /// 2.0121 Just as we cannot think of spatial objects at all apart from
        /// space, or temporal objects apart from time, so we cannot think
        /// of any object apart from the possibility of its connexion with
        /// other things.
        /// If I can think of an object in the context of an atomic fact,
        /// I cannot think of it apart from the possibility of this context.
        /// <para/>
        /// 2.013 Every thing is, as it were, in a space of possible atomic facts. I
        /// can think of this space as empty, but not of the thing without
        /// the space.
        /// <para/>
        /// 2.0131 A spatial object must lie in infinite space. (A point in space is
        /// a place for an argument.)
        /// A speck in a visual field need not be red, but it must have a
        /// colour; it has, so to speak, a colour space round it. A tone must
        /// have a pitch, the object of the sense of touch a hardness, etc.
        /// </summary>
        public bool IsValidToThinkAbout()
        {
            return Cases != null;
        }
    }
}