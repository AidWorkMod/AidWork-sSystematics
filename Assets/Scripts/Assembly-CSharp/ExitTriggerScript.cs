using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020000BF RID: 191
public class ExitTriggerScript : MonoBehaviour
{
	// Token: 0x06000962 RID: 2402 RVA: 0x000219A0 File Offset: 0x0001FDA0
	private void OnTriggerEnter(Collider other)
	{
		if (this.gc.notebooks >= this.gc.maxNotebooks & other.tag == "Player")
		{
			if (this.gc.failedNotebooks >= this.gc.maxNotebooks) //If the player got all the problems wrong on all the 7 notebooks
			{
				if (this.gc.mode == "ogStyled")
				{
                    this.gc.CorruptionActive();
                }
				else if (this.gc.mode == "story")
				{
					this.gc.Surprise();
				}
			}
			else
            {
                if (this.gc.mode == "ogStyled")
                {
					this.gc.CorruptionActive();	
                }
                else if (this.gc.mode == "story")
                {
                    SceneManager.LoadScene("Results"); //Go to the win screen
                }
			}
        }
	}

	// Token: 0x040005F6 RID: 1526
	public GameControllerScript gc;
}
