using System.Collections;
using System.Collections.Generic;
using UMA.CharacterSystem;
using UMA.Examples;
using UnityEngine;
using UnityEngine.UI;
using UMA;

public class ButtonsManager : MonoBehaviour
{
    public GameObject FemaleChar, MaleChar;
    public GameObject Camera;
    public CameraTrack CamTracker;
    public GameObject Create, ChangeGender, Changehair, ChangeTop, ChangePants;
    public DynamicCharacterAvatar targetAvatar;
    public List<UMA.UMATextRecipe> Fhairlist;
    public List<UMA.UMATextRecipe> Mhairlist;
    public List<UMA.UMATextRecipe> FPantslist;
    public List<UMA.UMATextRecipe> MPantslist;
    public List<UMA.UMATextRecipe> FShirtlist;
    public List<UMA.UMATextRecipe> Mshirtlist;
    private bool isMale=true;

    // Start is called before the first frame update
    void Awake()
    {
        if (Camera != null)
            CamTracker = Camera.GetComponent<CameraTrack>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CreateChar()
    {
        CamTracker.target = MaleChar.transform;
        targetAvatar = MaleChar.GetComponent<DynamicCharacterAvatar>();
        isMale = true;

        Create.SetActive(false);
        ChangeGender.SetActive(true);
        Changehair.SetActive(true);
        ChangeTop.SetActive(true);
        ChangePants.SetActive(true);



    }
    public void ChangeTarget()
    {
        if (CamTracker.target == MaleChar.transform)
        {
            isMale = false;
            CamTracker.target = FemaleChar.transform;
            targetAvatar = FemaleChar.GetComponent<DynamicCharacterAvatar>();

        }
            
        else if(CamTracker.target == FemaleChar.transform)
        {
                        isMale = true;
            CamTracker.target = MaleChar.transform;
            targetAvatar = MaleChar.GetComponent<DynamicCharacterAvatar>();

        }

    }
    short mA=0, mB=0, mC=0, fA=0, fB=0, fC=0;
    public void ChangeHair()
    {
        if (isMale)
        {
            if (mA < Mhairlist.Count)
            {
                targetAvatar.SetSlot("Hair", Mhairlist[mA].name);
                targetAvatar.BuildCharacter();
                mA++;
            }
            else
            {
                mA = 0;
                targetAvatar.SetSlot("Hair", Mhairlist[mA].name);
                targetAvatar.BuildCharacter();
            }
        }

        else
        {
            if (fA < Fhairlist.Count)
            {
                targetAvatar.SetSlot("Hair", Fhairlist[fA].name);
                targetAvatar.BuildCharacter();
                fA++;
            }
            else
            {
                fA = 0;
                targetAvatar.SetSlot("Hair", Fhairlist[fA].name);
                targetAvatar.BuildCharacter();
            }
        }
    }
    public void ChangeChest()
    {
        if (isMale)
        {
            if (mB < Mshirtlist.Count)
            {
                targetAvatar.SetSlot("Chest", Mshirtlist[mB].name);
                targetAvatar.BuildCharacter();
                mB++;
            }
            else
            {
                mB = 0;
                targetAvatar.SetSlot("Chest", Mshirtlist[mB].name);
                targetAvatar.BuildCharacter();
            }
        }

        else
        {
            if (fB < FShirtlist.Count)
            {
                targetAvatar.SetSlot("Chest", FShirtlist[fB].name);
                targetAvatar.BuildCharacter();
                fB++;
            }
            else
            {
                fB = 0;
                targetAvatar.SetSlot("Chest", FShirtlist[fB].name);
                targetAvatar.BuildCharacter();
            }
        }
    }
    public void ChangeLegs()
    {
        if (isMale)
        {
            if (mC < MPantslist.Count)
            {
                targetAvatar.SetSlot("Legs", MPantslist[mC].name);
                targetAvatar.BuildCharacter();
                mC++;
            }
            else
            {
                mC = 0;
                targetAvatar.SetSlot("Legs", MPantslist[mC].name);
                targetAvatar.BuildCharacter();
            }
        }

        else
        {
            if (fC < FPantslist.Count)
            {
                targetAvatar.SetSlot("Legs", FPantslist[fC].name);
                targetAvatar.BuildCharacter();
                fC++;
            }
            else
            {
                fC = 0;
                targetAvatar.SetSlot("Legs", FPantslist[fC].name);
                targetAvatar.BuildCharacter();
            }
        }
    }
}
