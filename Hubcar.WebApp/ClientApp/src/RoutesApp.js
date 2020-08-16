import React from 'react';
import { BrowserRouter, Route, Switch} from 'react-router-dom';
import Home from './components/Home';
import Counter from './components/Counter';
import FetchData from  './components/FetchData';

const Routers = [
    { path: '/', component: Home, exact: true },
    { path: '/', component: Counter, exact: false },
    { path: '/', component: FetchData, exact: false}
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
