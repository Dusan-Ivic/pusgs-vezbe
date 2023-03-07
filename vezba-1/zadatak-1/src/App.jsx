import "./App.css";
import LogoList from "./components/LogoList/LogoList";
import AngularLogo from "./assets/angular.png";
import ReactLogo from "./assets/react.png";
import VueLogo from "./assets/vue.png";

const logos = [
  {
    name: "Angular",
    image: AngularLogo,
  },
  {
    name: "React",
    image: ReactLogo,
  },
  {
    name: "Vue",
    image: VueLogo,
  },
];

function App() {
  return (
    <div className="App">
      <LogoList logos={logos} />
    </div>
  );
}

export default App;
