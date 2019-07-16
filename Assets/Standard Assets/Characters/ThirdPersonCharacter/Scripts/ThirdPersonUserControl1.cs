using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class ThirdPersonUserControl1 : MonoBehaviour
    {
        private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
        private Transform m_Cam;                  // A reference to the main camera in the scenes transform
        private Vector3 m_CamForward;             // The current forward direction of the camera
        private Vector3 m_Move = new Vector3(0, 0, 0);
        private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.

        public float m_MoveSpeed = 20f;
        public float m_TurnSpeed = 20f;
        

        private void Start()
        {
            
            m_Character = GetComponent<ThirdPersonCharacter>();
        }


        private void Update()
        {

        if (!m_Jump)
            {
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }

        if (Input.GetKeyDown(KeyCode.LeftShift)) m_MoveSpeed *= 5f;
        if (Input.GetKeyUp(KeyCode.LeftShift)) m_MoveSpeed /= 5f;
        if (Input.GetKeyDown(KeyCode.RightShift)) GetComponent<Rigidbody>().useGravity = false;
        if (Input.GetKeyUp(KeyCode.RightShift)) GetComponent<Rigidbody>().useGravity = true;

        if(Input.GetKey(KeyCode.UpArrow))
            //
            
            if (m_Jump)
			    {
				    GetComponent<Rigidbody>().AddForce(transform.forward * m_MoveSpeed * 50);
			    }
            else
                {
                    transform.Translate(Vector3.forward * m_MoveSpeed * Time.deltaTime);
                }

        
        if(Input.GetKey(KeyCode.DownArrow))
            if (m_Jump)
			    {
				    GetComponent<Rigidbody>().AddForce(transform.forward * m_MoveSpeed * -50);
			    }
            else
                {
                    transform.Translate(Vector3.forward * -m_MoveSpeed * Time.deltaTime);
                }
        
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -m_TurnSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, m_TurnSpeed * Time.deltaTime);
        }


        // Fixed update is called in sync with physics
        private void FixedUpdate()
        {
            // read inputs
            bool crouch = Input.GetKey(KeyCode.C);

            
#if !MOBILE_INPUT
			// walk speed multiplier
	        
#endif

            // pass all parameters to the character control script
            m_Character.Move(m_Move, crouch, m_Jump);
            m_Jump = false;
        }
    }
}
