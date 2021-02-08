import ResponsiveDrawer from './Layout';
import PersonalInformationForm from './PersonalInformationForm';
import NestedGrid from './NestedGrid';

const style = {
  marginTop: '10%'
}



const App = () => {
  return (
    <div className="App">
       <ResponsiveDrawer>
        <NestedGrid></NestedGrid>


       
       </ResponsiveDrawer>
    </div>
  );
}

export default App;
