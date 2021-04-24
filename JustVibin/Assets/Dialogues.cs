using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Dialogues : ScriptableObject
{
    public  Dialogue[,] logs = new Dialogue[20,20];
    //right in index, left is how bad is it going
   public void StartDialogues()
    {
        logs[0, 0] = new Dialogue("Hey, what's up?", "hey, omw.", "i told u already lol", "none of ur business");
        logs[0, 1] = new Dialogue("Okay :)", "its been a while haha", "what r u up to", "do u watch anime?");
        logs[0, 2] = new Dialogue("For sure! what have you been up to?? LOL", "wow where do i even start", "business, trying to stay in shape", "idk, not much");
        logs[0, 3] = new Dialogue("Hmm... what do u do nowadays?", "i run an insurance company", "trying to stay in shape", "anime tiddies");
        logs[0, 4] = new Dialogue("Oh really! my uncle used to work at one.", "nice, why did he stop?", "its a shit job honestly", "lol nice");
        logs[0, 5] = new Dialogue("Well, he passed quite recently", "oh damn, im so sorry", "damn", "lol");

        //from here til 25 it is when log 0,0 was answered neutrally, and from there on only good

        logs[1, 0] = new Dialogue("lol", "how are you kim?", "whats up anyways", "avocado");
        logs[1, 1] = new Dialogue("I'm alright... waiting for you ;)", "i cant wait honestly haha", "ill be there soon dont worry ;)", "lmao u freak");
        logs[1, 2] = new Dialogue("Well, u better", "u meanie", "i am", "better what?");
        logs[1, 3] = new Dialogue("Meanie?? me?? no way", "yeah u, meanie", "jk lol", "ur a disgusting human being");
        logs[1, 4] = new Dialogue("Wanna see something ;P", "what kind of something", "sure", "no");

        //from here til x it is when log 0,0 answered bad, rest is good

        logs[2, 0] = new Dialogue("Oh.. okay", "sorry ive been having alot on my head", "sorry if i offended u", "im on the cellphone");
        logs[2, 1] = new Dialogue("Okay...", "u probably dont wanna talk now :/", "im sorry", "send nudes?");
        logs[2, 2] = new Dialogue("u know what, its fine. Hows life been?", "well, i run an insurance company", "kinda rough", "banana");
        logs[2, 3] = new Dialogue("Oh, that's cool. My uncle used to work at that", "insurance? what did he do?", "thats cool", "wanna know the time?");
        logs[2, 4] = new Dialogue("Yeah... he passed recently", "im sorry to hear", "damn", "lol");



    }

}
