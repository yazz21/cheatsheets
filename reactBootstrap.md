import Button from 'react-bootstrap/Button';

// or less ideally
import { Button } from 'react-bootstrap';
Browser globals#
We provide react-bootstrap.js and react-bootstrap.min.js bundles with all components exported on the window.ReactBootstrap object. These bundles are available on jsDelivr, as well as in the npm package.

<script src="https://cdn.jsdelivr.net/npm/react/umd/react.production.min.js" crossorigin></script>

<script
  src="https://cdn.jsdelivr.net/npm/react-dom/umd/react-dom.production.min.js"
  crossorigin></script>

<script
  src="https://cdn.jsdelivr.net/npm/react-bootstrap@next/dist/react-bootstrap.min.js"
  crossorigin></script>

<script>var Alert = ReactBootstrap.Alert;</script>
Examples#
React-Bootstrap has started a repo with a few basic CodeSandbox examples. Click here to check them out.

Stylesheets#
Because React-Bootstrap doesn't depend on a very precise version of Bootstrap, we don't ship with any included CSS. However, some stylesheet is required to use these components.

CSS#
{/* The following line can be included in your src/index.js or App.js file */}

import 'bootstrap/dist/css/bootstrap.min.css';
How and which Bootstrap styles you include is up to you, but the simplest way is to include the latest styles from the CDN. A little more information about the benefits of using a CDN can be found here.

<link
  rel="stylesheet"
  href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css"
  integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi"
  crossorigin="anonymous"
/>
Sass#
In case you are using Sass the simplest way is to include the Bootstrap’s source Sass files in your main Sass file and then require it on your src/index.js or App.js file. This applies to a typical create-react-app application in other use cases you might have to setup the bundler of your choice to compile Sass/SCSS stylesheets to CSS.

/* The following line can be included in a src/App.scss */

@import "~bootstrap/scss/bootstrap";

/* The following line can be included in your src/index.js or App.js file */

import './App.scss';
Customize Bootstrap#
If you wish to customize the Bootstrap theme or any Bootstrap variables you can create a custom Sass file:

/* The following block can be included in a custom.scss */

/* make the customizations */
$theme-colors: (
    "info": tomato,
    "danger": teal
);

/* import bootstrap to set changes */
@import "~bootstrap/scss/bootstrap";
... And import it on the main Sass file.

/* The following line can be included in a src/App.scss */

@import "custom";
Advanced usage#
See the Bootstrap docs for more advanced use cases and details about customizing stylesheets.

as Prop API#
With certain React-Bootstrap components, you may want to modify the component or HTML tag that is rendered.

If you want to keep all the styling of a particular React-Bootstrap component but switch the component that is finally rendered (whether it's a different React-Bootstrap component, a different custom component, or a different HTML tag) you can use the as prop to do so.

The example below passes an anchor to the as prop in a Button component. This ultimately causes a a tag to be rendered but with the same styles as a Button component.

<Stack direction="horizontal" gap={2}>
  <Button as="a" variant="primary">
    Button as link
  </Button>
  <Button as="a" variant="success">
    Button as link
  </Button>
</Stack>
<Stack direction="horizontal" gap={2}>
  <Button as="a" variant="primary">
    Button as link
  </Button>
  <Button as="a" variant="success">
    Button as link
  </Button>
</Stack>
Below is an illustration of passing a React Bootstrap component. It contains a Badge component and a Button component that have been supplied to the as prop. This finally results in the rendering of a Button component with the same styles as a Badge component.

Example heading New
<div>
  <h1>
    Example heading{' '}
    <Badge bg="secondary" as="Button">
      New
    </Badge>
  </h1>
</div>
<div>
  <h1>
    Example heading{' '}
    <Badge bg="secondary" as="Button">
      New
    </Badge>
  </h1>
</div>
Themes#
React-Bootstrap is compatible with existing Bootstrap themes. Just follow the installation instructions for your theme of choice.

Watch out!
Because React-Bootstrap completely reimplements Bootstrap's JavaScript, it's not automatically compatible with themes that extend the default JavaScript behaviors.
Create React App
If you would like to add a custom theme on your app using Create React App, they have additional documentation for Create React App and Bootstrap here

Browser support#
We aim to support all browsers supported by both React and Bootstrap.