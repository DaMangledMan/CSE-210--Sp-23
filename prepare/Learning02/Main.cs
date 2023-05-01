
List<Job> jobs = new List<Job>();

Job softwareEngineer = new Job("Software Engineer", "Microsoft", 2019, 2022);
jobs.Add(softwareEngineer);

Job manager = new Job("Manager", "Apple", 2022, 2023);
jobs.Add(manager);

Resume resume = new Resume("Allison Rose", jobs);

resume.display();