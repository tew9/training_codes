# topic - devops

- what is devops?

  > the intersection of stakeholders, product and delivery process.
  > the stakeholders are development, business, operations

  - cycle time
    > the convergence of the iterative process
  - feedback loop
    > the synergy between dev (dev, test, analyze, package), ops (deploy, monitor, support, feedback) and biz (learn, observe, decide, require)
  - validation
    > are we on the right track, let's fail fast and learn from it. it will take into account cycle time and feedback loop. the outcome state can be good, inconclusive, bad.

- devops tooling?
  - continuous integration (create)
    > the process of developing a codebase to be deployed to a dev environment using an automated system of governance
  - continuous deployment (distribute)
    > the process of deploying a packaged versioned codebase to multiple environments with governance around security, performance, monitoring, analytics and various other metrics
  - pipeline
    > the implementation using code/markup of CI/CD process
    - build definition (CI)
      > a set of events to trigger when code is pushed to SCM to include compilation, unit testing, code analysis, image packaging and notification loop
    - release definition (CD)
      > a set of events to trigger when image is pushed to DEV environment to include vairous other environments such as TEST/QA, STG, SUPPORT, UAT up to PROD
    - code analysis
      - static code analysis (SonarQube/SonarCloud)
        > read the codebase verbatim post-compile time and detect code snippets/patterns known to cause vulnerabilities, code smells, security issues, potential bugs
      - dynamic code analysis (WhiteSource)
        > read the codebase both post-compile and post-runtime and detect code snippets/patterns known to be vulnerable
      - sonarcloud
        - quality profile
          > subset of rules that should be used in analysis
        - quality gate
          > level of tolerance/threshold of rule failure
        - analysis rule
          > know code snippet/pattern that ccan cause an issue
        - technical debt
          > estimated amount of time necessary to fix an issue
        - vulnerability
          > runtime defect
        - code smell
          > code statement that should be removed due to ambiguity
        - security
          > code statement that can output potential secret or architectural design of application
        - code coverage
          > amount of lines covered versus written in running unit tests againg the codebase
        - duplication
          > set of code statements that are repeated multiple throughout the codebase
