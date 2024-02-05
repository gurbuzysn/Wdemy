let sectionList = [];


function showSection() {
    let section = document.getElementById("sectionSubmit");
    section.removeAttribute("hidden");
}
async function submitSection(courseId) {
    let sectionName = document.getElementById("SectionName").value;

    console.log(courseId);

    if (sectionName !== null) {
        let sectionVM = {
            SectionName: sectionName,
            CourseId: courseId
        }
        sectionList.push(sectionVM);

        
        updateList(sectionVM);
        resetInput(sectionName);
        document.getElementById("sectionList").value = JSON.stringify(sectionList);
    }
}
function updateList(sectionVM) {
    let accordion = document.getElementById("accordionFlushExample");

    let template = `<div class="accordion-item">
                                <h2 class="accordion-header" id="flush-headingOne">
                                    <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#flush-collapse-${sectionVM.SectionName}" aria-expanded="false" aria-controls="flush-collapseOne">
                                        ${sectionVM.SectionName}
                                    </button>
                                </h2>
                                <div id="flush-collapse-${sectionVM.SectionName}" class="accordion-collapse collapse" aria-labelledby="flush-headingOne" data-bs-parent="#accordionFlushExample">
                                    <div class="accordion-body"></div>
                                </div>
                            </div>`;

    accordion.innerHTML += template;
}

function resetInput(sectionName) {
    sectionName = "";
}

