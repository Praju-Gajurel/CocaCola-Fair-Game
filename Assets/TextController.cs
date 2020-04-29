using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class TextController : MonoBehaviour {

    public AudioSource correctAnswer;
    public AudioSource incorrectAnswer;

	public Text majorTitleText;
	public Text Button1Text;
	public Text Button2Text;
	public Text Button3Text;
	public Text Button4Text;
    public Text Button5Text;
    public Text Button6Text;

    public Button button1, button2, button3, button4, button5;

    public GameObject buttonFive;

    public int which1;
    public int which2;
    public int which3;
    public int which4;
    public int which5;
    public int which0;

    public int score;

    List<string> majors = new List<string>();
    List<string> jobs = new List<string>();
    List<string> tempList = new List<string>();

    void Shuffle()
    {
        for (int i = 0; i < 4; i++)
        {
            string temp = tempList[i];
            int randomIndex = Random.Range(i, tempList.Count);
            tempList[i] = tempList[randomIndex];
            tempList[randomIndex] = temp;
        }
    }

    void ClickedOne()
    {
        if(tempList[0] == jobs[which0])
        {
            Button5Text.text = "Correct!";
            score++;
            Button6Text.text = "Streak: " + score;
            correctAnswer.Play();
            button1.image.color = Color.green;
        }
        else
        {
            Button5Text.text = "Oh, sorry, not quite!";
            score = 0;
            Button6Text.text = "Streak: 0";
            incorrectAnswer.Play();
            button1.image.color = Color.red;
        }
        buttonFive.SetActive(true);
    }

    void ClickedTwo()
    {
        if (tempList[1] == jobs[which0])
        {
            Button5Text.text = "Correct!";
            score++;
            Button6Text.text = "Streak: " + score;
            correctAnswer.Play();
            button2.image.color = Color.green;
        }
        else
        {
            Button5Text.text = "Oh, sorry, not quite!";
            score = 0;
            Button6Text.text = "Streak: 0";
            incorrectAnswer.Play();
            button2.image.color = Color.red;
        }
        buttonFive.SetActive(true);
    }

    void ClickedThree()
    {
        if (tempList[2] == jobs[which0])
        {
            Button5Text.text = "Correct!";
            score++;
            Button6Text.text = "Streak: " + score;
            correctAnswer.Play();
            button3.image.color = Color.green;
        }
        else
        {
            Button5Text.text = "Oh, sorry, not quite!";
            score = 0;
            Button6Text.text = "Streak: 0";
            incorrectAnswer.Play();
            button3.image.color = Color.red;
        }
        buttonFive.SetActive(true);
    }

    void ClickedFour()
    {
        if (tempList[3] == jobs[which0])
        {
            Button5Text.text = "Correct!";
            score++;
            Button6Text.text = "Streak: " + score;
            correctAnswer.Play();
            button4.image.color = Color.green;
        }
        else
        {
            Button5Text.text = "Oh, sorry, not quite!";
            score = 0;
            Button6Text.text = "Streak: 0";
            incorrectAnswer.Play();
            button4.image.color = Color.red;
        }
        buttonFive.SetActive(true);
    }

    void ClickedFeedback()
    {
        UpdateContent();
        buttonFive.SetActive(false);
        button1.image.color = Color.white;
        button2.image.color = Color.white;
        button3.image.color = Color.white;
        button4.image.color = Color.white;
    }

    // Use this for initialization
    void Start () {

        score = 0;
        Button6Text.text = "Streak: 0";

        Button btn1 = button1.GetComponent<Button>();
        Button btn2 = button2.GetComponent<Button>();
        Button btn3 = button3.GetComponent<Button>();
        Button btn4 = button4.GetComponent<Button>();
        Button btn5 = button5.GetComponent<Button>();

        btn1.onClick.AddListener(ClickedOne);
        btn2.onClick.AddListener(ClickedTwo);
        btn3.onClick.AddListener(ClickedThree);
        btn4.onClick.AddListener(ClickedFour);
        btn5.onClick.AddListener(ClickedFeedback);

        buttonFive.SetActive(false);

        jobs.Add("Higher Education");
        jobs.Add("Information/Library Science");
        jobs.Add("Preservation and Conservation Research");
        jobs.Add("Travel Writer (Journalist)");
        jobs.Add("Archaeologist");
        jobs.Add("Social Welfare Administrator");
        jobs.Add("Historic Site Administrator");
        jobs.Add("Sociologist");
        jobs.Add("Historian");
        jobs.Add("Museum Curator");
        jobs.Add("Archivist");
        jobs.Add("Anthropologist");
        jobs.Add("Area and Cultural Studies Professor");
        jobs.Add("Community Outreach Manager");
        jobs.Add("Community Welfare Worker");
        jobs.Add("Social Psychologist");
        jobs.Add("Social Worker");
        jobs.Add("Art Curriculum Writing");
        jobs.Add("Art History");
        jobs.Add("Art Teacher");
        jobs.Add("Formalized Instruction");
        jobs.Add("Recreational Instruction");
        jobs.Add("Preschool Teacher");
        jobs.Add("Kindergarten Teacher");
        jobs.Add("High School Teacher");
        jobs.Add("Middle School Teacher");
        jobs.Add("Elementary School Teacher");
        jobs.Add("Architect");
        jobs.Add("Art Appraiser");
        jobs.Add("Art Director");
        jobs.Add("Art Restorer");
        jobs.Add("Art Therapist");
        jobs.Add("Artists Agents");
        jobs.Add("Commercial Designer");
        jobs.Add("Fashion Artist");
        jobs.Add("Fashion Designer");
        jobs.Add("Fine Artist");
        jobs.Add("Furniture Designer");
        jobs.Add("Model Maker");
        jobs.Add("Museum/Gallery Administration");
        jobs.Add("Package Designer");
        jobs.Add("Painter");
        jobs.Add("Sculptors");
        jobs.Add("Technical Illustrator");
        jobs.Add("Textile Designer");
        jobs.Add("Toy Designer");
        jobs.Add("Web Art Director");
        jobs.Add("Exhibit Designer");
        jobs.Add("Graphic Designer");
        jobs.Add("Illustrator");
        jobs.Add("Multimedia Artist and Animator");
        jobs.Add("Set Designer");
        jobs.Add("Set Illustrator");
        jobs.Add("Interior Designer");
        jobs.Add("Advertising");
        jobs.Add("Cartoonist");
        jobs.Add("Policy Analyst");
        jobs.Add("Travel Writer");
        jobs.Add("Education");
        jobs.Add("Advertising Account Manager");
        jobs.Add("Literacy and Remedial Education Teachers");
        jobs.Add("Management");
        jobs.Add("Personnel Administrator");
        jobs.Add("Speech Pathologist");
        jobs.Add("Training and Development Manager");
        jobs.Add("Voice Pathologist");
        jobs.Add("Speech Writer");
        jobs.Add("Training and Development Specialist");
        jobs.Add("Public Relations Specialist");
        jobs.Add("Public Relations Manager");
        jobs.Add("Human Resources Management Adviser");
        jobs.Add("Human Resources Management Consultant");
        jobs.Add("Communications Professor");
        jobs.Add("Mediator");
        jobs.Add("Advertising/Marketing (creative)");
        jobs.Add("Article Writer");
        jobs.Add("Author");
        jobs.Add("Blogger");
        jobs.Add("Columnist");
        jobs.Add("Ghostwriter");
        jobs.Add("Greeting Card Writer");
        jobs.Add("Instructor");
        jobs.Add("Personal Poet");
        jobs.Add("Playwrite");
        jobs.Add("Proofreader");
        jobs.Add("Public Relations");
        jobs.Add("Researcher");
        jobs.Add("Reviewer (books, products, etc.)");
        jobs.Add("Screenwriter");
        jobs.Add("Video Game Writer");
        jobs.Add("Website Content Writer");
        jobs.Add("Writing Coach/Consultant");
        jobs.Add("Grant Writer");
        jobs.Add("Editor");
        jobs.Add("Technical Publications Writer");
        jobs.Add("Librarian");
        jobs.Add("Parole Officer");
        jobs.Add("Intelligence Specialist");
        jobs.Add("Correctional Officer");
        jobs.Add("Criminal Justice Professor");
        jobs.Add("Investigative Assistant");
        jobs.Add("Legal Consultant");
        jobs.Add("Legal Research");
        jobs.Add("Litigation Analyst");
        jobs.Add("Paralegal");
        jobs.Add("Police and Detectives Supervisor");
        jobs.Add("Safety and Security Officer");
        jobs.Add("Transportation Security Screener");
        jobs.Add("Contract Administration");
        jobs.Add("Emergency Management Specialist");
        jobs.Add("Court Reporting");
        jobs.Add("Compliance Risk Analysis");
        jobs.Add("Cyber Management");
        jobs.Add("Cyber Security Analysis");
        jobs.Add("Cyber Security Tester");
        jobs.Add("Cyber Security Threat Analyst");
        jobs.Add("Cyber Threat Vulnerability");
        jobs.Add("Incidence Response");
        jobs.Add("Product Manager");
        jobs.Add("Event/Convention Planner");
        jobs.Add("Radio & TV Show Host");
        jobs.Add("Radio & TV Sports Announcer");
        jobs.Add("Radio & TV News Commentator");
        jobs.Add("Radio & TV Newscaster");
        jobs.Add("Screen Writer");
        jobs.Add("Radio & TV Program Director");
        jobs.Add("Radio & TV Producer");
        jobs.Add("Choreographer");
        jobs.Add("Composer");
        jobs.Add("Music Arranger and Orchestrator");
        jobs.Add("Singer");
        jobs.Add("Actor/Actress");
        jobs.Add("Dancer");
        jobs.Add("Talent Agent");
        jobs.Add("Technical Director/Manager");
        jobs.Add("Theater and Media Director");
        jobs.Add("English as a Second Language");
        jobs.Add("Reading Specialist");
        jobs.Add("English Language and Literature Professor");
        jobs.Add("Teacher");
        jobs.Add("Principal");
        jobs.Add("Superintendent");
        jobs.Add("Tutoring Services");
        jobs.Add("Creative Writer");
        jobs.Add("Journalist");
        jobs.Add("Marketing");
        jobs.Add("Newspaper Editor");
        jobs.Add("Publications Editor");
        jobs.Add("Editorial Writer, Newspapers & Magazines");
        jobs.Add("Newspaper/Magazine Writer");
        jobs.Add("Reporter");
        jobs.Add("Market Research Analyst");
        jobs.Add("Broadcast News Analyst");
        jobs.Add("Writer / Author");
        jobs.Add("Lobbyist");
        jobs.Add("Copy Writer");
        jobs.Add("Script Editor");
        jobs.Add("Sportswriter");
        jobs.Add("Technical & Scientific Publications Editor");
        jobs.Add("Legislative Assistant");
        jobs.Add("Fundraising Manager");
        jobs.Add("Scientific Linguist");
        jobs.Add("Administrative Service Manager");
        jobs.Add("Chef");
        jobs.Add("Credit Analyst");
        jobs.Add("Insurance Agent");
        jobs.Add("Law Clerk");
        jobs.Add("Marketing Manager");
        jobs.Add("Retail Buyer");
        jobs.Add("Urban and Regional Planner");
        jobs.Add("Management Consultant");
        jobs.Add("Social and Human Service Assistant");
        jobs.Add("Social Science Research Assistant");
        jobs.Add("Hotel Manager");
        jobs.Add("Cartographer and Photogrammetrist");
        jobs.Add("Climatologist");
        jobs.Add("Conservationist");
        jobs.Add("Environmental Management");
        jobs.Add("Forester");
        jobs.Add("Geographer");
        jobs.Add("Geography Professor");
        jobs.Add("Geologist");
        jobs.Add("Geophysicist");
        jobs.Add("Hazardous Waste Management Analyst");
        jobs.Add("Historic Preservationist");
        jobs.Add("Hydrologist");
        jobs.Add("Landscape Architect");
        jobs.Add("Mapping Technician");
        jobs.Add("Oceanographer");
        jobs.Add("Outdoor Education Teacher");
        jobs.Add("Seismologist");
        jobs.Add("Soil Conservation Technician");
        jobs.Add("Soil Conservationist");
        jobs.Add("Soil Scientist");
        jobs.Add("Surveyor");
        jobs.Add("Water Pollution Control Inspector");
        jobs.Add("Park Naturalist");
        jobs.Add("City Management");
        jobs.Add("Clergy Member");
        jobs.Add("History Professor");
        jobs.Add("Regional Planning");
        jobs.Add("Attorney");
        jobs.Add("Congressional Aide");
        jobs.Add("Labor Relations Specialist");
        jobs.Add("Government Service Executive");
        jobs.Add("Anti-Terrorism Intelligence Agent");
        jobs.Add("Foreign Service Officer");
        jobs.Add("Chaplain");
        jobs.Add("Museum Technicians and Conservator");
        jobs.Add("Foreign Language Interpreter");
        jobs.Add("Foreign Language Translator");
        jobs.Add("Library Consultant");
        jobs.Add("Correspondent");
        jobs.Add("Director");
        jobs.Add("Private Lesson Instructor");
        jobs.Add("Music Director");
        jobs.Add("Music Teacher");
        jobs.Add("Music Therapist");
        jobs.Add("Musician");
        jobs.Add("Recreational Therapist");
        jobs.Add("Adjudicator");
        jobs.Add("Administrative Law Judge");
        jobs.Add("Admiralty Lawyer");
        jobs.Add("Appeals Examiner");
        jobs.Add("City Planning Aide");
        jobs.Add("Compliance Officer");
        jobs.Add("Corporation Lawyer");
        jobs.Add("Criminal Lawyer");
        jobs.Add("Fund Raiser");
        jobs.Add("Industrial Relations Specialist");
        jobs.Add("Judge");
        jobs.Add("Personnel Coordinator");
        jobs.Add("Political Scientist");
        jobs.Add("Technological Espionage Intelligence Agent");
        jobs.Add("Probation Officer");
        jobs.Add("Social and Community Service Manager");
        jobs.Add("Criminalist");
        jobs.Add("Survey Researcher");
        jobs.Add("Equal Opportunity Representative");
        jobs.Add("Arbitrator");
        jobs.Add("Conciliator");
        jobs.Add("Police Detective");
        jobs.Add("Camp Director");
        jobs.Add("Clinical Psychologist");
        jobs.Add("Counseling Psychologist");
        jobs.Add("Developmental Psychologist");
        jobs.Add("Industrial Therapist");
        jobs.Add("Marriage and Family Therapist");
        jobs.Add("Mental Health Counselor");
        jobs.Add("Occupational Therapist");
        jobs.Add("Patient Advocate");
        jobs.Add("Residence Counselor");
        jobs.Add("School Psychologist");
        jobs.Add("Social Work Professor");
        jobs.Add("Vocational Rehabilitation Counselor");
        jobs.Add("Career / Guidance Counselor");
        jobs.Add("Child Care Center Administrator");
        jobs.Add("Child Support Services Worker");
        jobs.Add("Clinical Sociologist");
        jobs.Add("Healthcare Social Worker");
        jobs.Add("Substance Abuse Counselor");
        jobs.Add("Youth Services Specialist");
        jobs.Add("Family Caseworker");
        jobs.Add("Missionary Worker");
        jobs.Add("High School Guidance Counselor");
        jobs.Add("Sociology Professor");
        jobs.Add("Foreign Language Professor");
        jobs.Add("Foreign Student Adviser");
        jobs.Add("Foreign Exchange Trader");
        jobs.Add("Housekeeping Supervisor");
        jobs.Add("Middle School Guidance Counselor");

        majors.Add("American Indian Studies, B.A.");
        majors.Add("American Indian Studies, B.A.");
        majors.Add("American Indian Studies, B.A.");
        majors.Add("American Indian Studies, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nGeneral Studies, B.G.S.\nHistory, B.A.\nPolitical Science, B.A.\nSocial Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.\nSpanish, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nHistory, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nHistory, B.A.\nPolitical Science, B.A.\nSocial Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nHistory, B.A.\nPolitical Science, B.A.\nSpanish, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nHistory, B.A.\nSociology, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nHistory, B.A.\nSpanish, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nPolitical Science, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nSocial Studies Education, B.A.Ed.\nSpanish, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nSocial Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nSocial Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nSocial Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("American Indian Studies, B.A.\nCherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nSocial Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.\nSpanish, B.A.");
        majors.Add("Art Education, B.A.Ed.");
        majors.Add("Art Education, B.A.Ed.");
        majors.Add("Art Education, B.A.Ed.\nArt, B.F.A.");
        majors.Add("Art Education, B.A.Ed.\nArt, B.F.A.");
        majors.Add("Art Education, B.A.Ed.\nArt, B.F.A.");
        majors.Add("Art Education, B.A.Ed.\nDrama, B.A.");
        majors.Add("Art Education, B.A.Ed.\nDrama, B.A.\nEnglish, B.A.");
        majors.Add("Art Education, B.A.Ed.\nEnglish Education, B.A.Ed.\nEnglish, B.A.\nGeneral Studies, B.G.S.\nHistory, B.A.\nMusic Education, B.M.Ed.\nSocial Studies Education, B.A.Ed.\nSpanish Education, B.A.Ed.\nSpanish, B.A.");
        majors.Add("Art Education, B.A.Ed.\nEnglish Education, B.A.Ed.\nEnglish, B.A.\nMusic Education, B.M.Ed.\nSocial Studies Education, B.A.Ed.\nSpanish Education, B.A.Ed.\nSpanish, B.A.");
        majors.Add("Art Education, B.A.Ed.\nEnglish Education, B.A.Ed.\nEnglish, B.A.\nMusic Education, B.M.Ed.\nSocial Studies Education, B.A.Ed.\nSpanish, B.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.");
        majors.Add("Art, B.F.A.\nDrama, B.A.");
        majors.Add("Art, B.F.A.\nDrama, B.A.");
        majors.Add("Art, B.F.A.\nDrama, B.A.");
        majors.Add("Art, B.F.A.\nDrama, B.A.");
        majors.Add("Art, B.F.A.\nDrama, B.A.");
        majors.Add("Art, B.F.A.\nDrama, B.A.");
        majors.Add("Art, B.F.A.\nDrama, B.A.\nGeneral Studies, B.G.S.");
        majors.Add("Art, B.F.A.\nEnglish, B.A.");
        majors.Add("Art, B.F.A.\nMedia Studies, B.A.");
        majors.Add("Cherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.");
        majors.Add("Cherokee Cultural Studies, B.A.\nCherokee Education, B.A.Ed.\nCreative Writing, B.A.\nEnglish, B.A.\nHistory, B.A.\nMedia Studies, B.A.\nSpanish, B.A.");
        majors.Add("Cherokee Education, B.A.Ed.");
        majors.Add("Communication Studies, B.A.");
        majors.Add("Communication Studies, B.A.");
        majors.Add("Communication Studies, B.A.");
        majors.Add("Communication Studies, B.A.");
        majors.Add("Communication Studies, B.A.");
        majors.Add("Communication Studies, B.A.");
        majors.Add("Communication Studies, B.A.");
        majors.Add("Communication Studies, B.A.\nCreative Writing, B.A.\nEnglish, B.A.\nMedia Studies, B.A.");
        majors.Add("Communication Studies, B.A.\nDrama, B.A.");
        majors.Add("Communication Studies, B.A.\nEnglish, B.A.\nGeneral Studies, B.G.S.\nHistory, B.A.\nMedia Studies, B.A.\nPolitical Science, B.A.");
        majors.Add("Communication Studies, B.A.\nGeneral Studies, B.G.S.\nHistory, B.A.\nMedia Studies, B.A.\nSociology, B.A.");
        majors.Add("Communication Studies, B.A.\nGeneral Studies, B.G.S.\nSociology, B.A.");
        majors.Add("Communication Studies, B.A.\nGeneral Studies, B.G.S.\nSociology, B.A.");
        majors.Add("Communication Studies, B.A.\nMedia Studies, B.A.");
        majors.Add("Communication Studies, B.A.\nSpanish, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.");
        majors.Add("Creative Writing, B.A.\nEnglish, B.A.");
        majors.Add("Creative Writing, B.A.\nEnglish, B.A.\nGeneral Studies, B.G.S.\nMedia Studies, B.A.");
        majors.Add("Creative Writing, B.A.\nEnglish, B.A.\nGeography, B.A.\nMedia Studies, B.A.");
        majors.Add("Creative Writing, B.A.\nEnglish, B.A.\nHistory, B.A.\nMusic, B.A.\nSpanish, B.A.");
        majors.Add("Criminal Justice, B.S.\nGeneral Studies, B.G.S.\nHomeland Security, B.S.\nLegal Studies, B.S.\nPolitical Science, B.A.\nSocial Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.\nSpanish, B.A.");
        majors.Add("Criminal Justice, B.S.\nHistory, B.A.\nHomeland Security, B.S.\nLegal Studies, B.S.\nPolitical Science, B.A.\nSpanish, B.A.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.\nPolitical Science, B.A.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.\nPolitical Science, B.A.");
        majors.Add("Criminal Justice, B.S.\nHomeland Security, B.S.\nLegal Studies, B.S.\nSpanish, B.A.");
        majors.Add("Cyber Security, B.S.");
        majors.Add("Cyber Security, B.S.");
        majors.Add("Cyber Security, B.S.");
        majors.Add("Cyber Security, B.S.");
        majors.Add("Cyber Security, B.S.");
        majors.Add("Cyber Security, B.S.");
        majors.Add("Cyber Security, B.S.");
        majors.Add("Cyber Security, B.S.");
        majors.Add("Drama, B.A.");
        majors.Add("Drama, B.A.");
        majors.Add("Drama, B.A.");
        majors.Add("Drama, B.A.\nEnglish, B.A.\nMedia Studies, B.A.");
        majors.Add("Drama, B.A.\nEnglish, B.A.\nMedia Studies, B.A.");
        majors.Add("Drama, B.A.\nEnglish, B.A.\nMedia Studies, B.A.");
        majors.Add("Drama, B.A.\nEnglish, B.A.\nMusic, B.A.");
        majors.Add("Drama, B.A.\nGeneral Studies, B.G.S.\nMusic, B.A.");
        majors.Add("Drama, B.A.\nMusic Education, B.M.Ed.\nMusic, B.A.");
        majors.Add("Drama, B.A.\nMusic Education, B.M.Ed.\nMusic, B.A.");
        majors.Add("Drama, B.A.\nMusic Education, B.M.Ed.\nMusic, B.A.");
        majors.Add("Drama, B.A.\nMusic Education, B.M.Ed.\nMusic, B.A.");
        majors.Add("Drama, B.A.\nMusic, B.A.");
        majors.Add("Drama, B.A.\nMusic, B.A.");
        majors.Add("Drama, B.A.\nMusic, B.A.");
        majors.Add("Drama, B.A.\nMusic, B.A.");
        majors.Add("Drama, B.A.\nMusic, B.A.");
        majors.Add("English Education, B.A.Ed.");
        majors.Add("English Education, B.A.Ed.");
        majors.Add("English Education, B.A.Ed.\nEnglish, B.A.");
        majors.Add("English Education, B.A.Ed.\nMusic Education, B.M.Ed.");
        majors.Add("English Education, B.A.Ed.\nSocial Studies Education, B.A.Ed.\nSpanish Education, B.A.Ed.");
        majors.Add("English Education, B.A.Ed.\nSocial Studies Education, B.A.Ed.\nSpanish Education, B.A.Ed.");
        majors.Add("English Education, B.A.Ed.\nSocial Studies Education, B.A.Ed.\nSpanish Education, B.A.Ed.");
        majors.Add("English, B.A.");
        majors.Add("English, B.A.");
        majors.Add("English, B.A.");
        majors.Add("English, B.A.\nGeneral Studies, B.G.S.\nHistory, B.A.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nGeneral Studies, B.G.S.\nHistory, B.A.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nGeneral Studies, B.G.S.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nGeneral Studies, B.G.S.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nGeneral Studies, B.G.S.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nGeneral Studies, B.G.S.\nPolitical Science, B.A.\nSociology, B.A.");
        majors.Add("English, B.A.\nHistory, B.A.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nHistory, B.A.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nHistory, B.A.\nPolitical Science, B.A.");
        majors.Add("English, B.A.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nMedia Studies, B.A.");
        majors.Add("English, B.A.\nPolitical Science, B.A.");
        majors.Add("English, B.A.\nPolitical Science, B.A.\nSociology, B.A.");
        majors.Add("English, B.A.\nSociology, B.A.\nSpanish, B.A.");
        majors.Add("General Studies, B.G.S.");
        majors.Add("General Studies, B.G.S.");
        majors.Add("General Studies, B.G.S.");
        majors.Add("General Studies, B.G.S.");
        majors.Add("General Studies, B.G.S.");
        majors.Add("General Studies, B.G.S.");
        majors.Add("General Studies, B.G.S.");
        majors.Add("General Studies, B.G.S.\nGeography, B.A.\nHistory, B.A.\nPolitical Science, B.A.\nSociology, B.A.");
        majors.Add("General Studies, B.G.S.\nPolitical Science, B.A.");
        majors.Add("General Studies, B.G.S.\nSocial Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.\nSpanish, B.A.");
        majors.Add("General Studies, B.G.S.\nSociology, B.A.");
        majors.Add("General Studies, B.G.S.\nSpanish, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.");
        majors.Add("Geography, B.A.\nHistory, B.A.");
        majors.Add("History, B.A.");
        majors.Add("History, B.A.");
        majors.Add("History, B.A.");
        majors.Add("History, B.A.");
        majors.Add("History, B.A.\nPolitical Science, B.A.");
        majors.Add("History, B.A.\nPolitical Science, B.A.");
        majors.Add("History, B.A.\nPolitical Science, B.A.");
        majors.Add("History, B.A.\nPolitical Science, B.A.\nSociology, B.A.");
        majors.Add("History, B.A.\nPolitical Science, B.A.\nSpanish, B.A.");
        majors.Add("History, B.A.\nPolitical Science, B.A.\nSpanish, B.A.");
        majors.Add("History, B.A.\nSocial Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("History, B.A.\nSociology, B.A.");
        majors.Add("History, B.A.\nSpanish Education, B.A.Ed.\nSpanish, B.A.");
        majors.Add("History, B.A.\nSpanish Education, B.A.Ed.\nSpanish, B.A.");
        majors.Add("History, B.A.\nSpanish, B.A.");
        majors.Add("Media Studies, B.A.");
        majors.Add("Music Education, B.M.Ed.");
        majors.Add("Music Education, B.M.Ed.");
        majors.Add("Music Education, B.M.Ed.\nMusic, B.A.");
        majors.Add("Music Education, B.M.Ed.\nMusic, B.A.");
        majors.Add("Music Education, B.M.Ed.\nMusic, B.A.");
        majors.Add("Music Education, B.M.Ed.\nMusic, B.A.");
        majors.Add("Music, B.A.\nSocial Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.");
        majors.Add("Political Science, B.A.\nSocial Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("Political Science, B.A.\nSocial Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.\nSpanish, B.A.");
        majors.Add("Political Science, B.A.\nSociology, B.A.");
        majors.Add("Political Science, B.A.\nSociology, B.A.");
        majors.Add("Political Science, B.A.\nSociology, B.A.\nSpanish, B.A.");
        majors.Add("Political Science, B.A.\nSpanish, B.A.");
        majors.Add("Political Science, B.A.\nSpanish, B.A.");
        majors.Add("Political Science, B.A.\nSpanish, B.A.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.\nSpanish, B.A.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.\nSociology, B.A.\nSpanish, B.A.");
        majors.Add("Social Work, B.S.W.\nSocial Work, M.S.W.\nSpanish, B.A.");
        majors.Add("Sociology, B.A.");
        majors.Add("Spanish Education, B.A.Ed.\nSpanish, B.A.");
        majors.Add("Spanish Education, B.A.Ed.\nSpanish, B.A.");
        majors.Add("Spanish, B.A.");
        majors.Add("Spanish, B.A.");
        majors.Add("Spanish, B.A.");

        UpdateContent();
    }

    // Update is called once per frame
	void UpdateContent () {

        which0 = Random.Range(0, 270);
        which1 = Random.Range(0, 270);
        while (jobs[which0] == jobs[which1])
        {
            which1 = Random.Range(0, 270);
        }
        which2 = Random.Range(0, 270);
        while (jobs[which0] == jobs[which2] || jobs[which1] == jobs[which2])
        {
            which2 = Random.Range(0, 270);
        }
        which3 = Random.Range(0, 270);
        while (jobs[which0] == jobs[which3] || jobs[which1] == jobs[which3] || jobs[which2] == jobs[which3])
        {
            which3 = Random.Range(0, 270);
        }
        majorTitleText.text = majors[which0];
        tempList.Clear();
        tempList.Add(jobs[which0]);
        tempList.Add(jobs[which1]);
        tempList.Add(jobs[which2]);
        tempList.Add(jobs[which3]);
        Shuffle();
        Button1Text.text = tempList[0];
        Button2Text.text = tempList[1];
        Button3Text.text = tempList[2];
        Button4Text.text = tempList[3];
    }  
}
