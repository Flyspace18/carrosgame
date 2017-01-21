using UnityEngine;


public class UserInput : MonoBehaviour
{
    private CarControl m_Car; 

    float h;
    float accel;
    float brake;
    float handbrake;
    float revears;
    bool toggleDriftSystem;
	public float SPEED = (float)0.5;
	public float THRESHOLD = (float)0.3;

   const string Horizontal_KEY = "Horizontal";
    const string Vertical_KEY = "Vertical";
    const string NITRO_KEY = "Fire2";
    const string HANDBRAKE_KEY = "Fire1";
    //const string DRIFT_SYSTEM_KEY = KeyCode.A;
    bool activeNitro;
	public int fingerCount;
    
    void Start()
    {
    
        m_Car = GetComponent<CarControl>();
    }




    void Update()
    {
       // toggleDriftSystem = Input.GetKeyUp(KeyCode.A);
       // if (toggleDriftSystem)
       //     m_Car.toggleDriftSystem();


		////////////// TELEMOVEL
		if (h <0.1 && h>-0.1 ) { }else { 
			h = h - (h / 10);
		}

		var touch = Input.GetTouch(0);
		if (touch.position.x < Screen.width / 2)
		{
			if (h > -1.1)
			{ h = h - (float)0.2; }
		}
		else if (touch.position.x > Screen.width / 2)
		{
			if (h < 1.1)
			{ h = h + (float)0.2; }
		}
		////////////// TELEMOVEL

    }

 

    void FixedUpdate()
    {

		if (Input.GetKey(KeyCode.Escape))
		{
			// Insert Code Here (I.E. Load Scene, Etc)
			// OR Application.Quit();
			Application.LoadLevel(Application.loadedLevel);

		}
        // h =  Input.GetAxis(Horizontal_KEY) ;
		//print(Input.GetAxis(Vertical_KEY));
		//print(Input.GetAxis(Horizontal_KEY));
		
		
		
        //accel = brake = Input.GetAxis(Vertical_KEY) ;
		
		accel = brake = 1 ;
		
       // handbrake = Input.GetAxis(HANDBRAKE_KEY);

        m_Car.Move(h, accel, brake, handbrake); // pass the input to the car!
      //  activeNitro = Input.GetButton(NITRO_KEY);
      //  m_Car.nitro(activeNitro);

       
    }
   
}

