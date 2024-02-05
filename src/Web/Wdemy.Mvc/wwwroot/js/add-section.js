function showSection() {
    let section = document.getElementById("sectionSubmit");
    section.removeAttribute("hidden");
}

async function submitSection(courseId)
{
    let sectionName = document.getElementById("SectionName").value;

    console.log(courseId);

    if (sectionName !== null) {
        let sectionVM = {
            SectionName: sectionName,
            CourseId: courseId 
        }

       $.ajax({
           url: "/Trainer/Course/CreateSection",
           method: "POST",
           data: { sectionVM: sectionVM },
           
           success: function (data) {
               console.log(data);
           }
       })


    }

}
