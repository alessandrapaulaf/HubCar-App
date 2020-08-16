import React from 'react';
import { BrowserRouter, Route, Switch} from 'react-router-dom';
import HomePage from './pages/home-page';

const Routers = [
    { path: '/', component: HomePage, exact: true },
];  

const RouteApps = ({location}) => {
    return(
        <BrowserRouter>
            <Switch>
                {Routers.map((route, index) => (
                <Route location={location} path={route.path} key={index} component={route.component} /> 
                ))}
            </Switch>
        </BrowserRouter>
    );
}

export default RouteApps;
