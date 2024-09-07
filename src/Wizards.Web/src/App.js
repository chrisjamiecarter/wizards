import logo from './logo.svg';
import './App.css';
import React, { useState, useEffect } from 'react';

function App() {

    const [data, setData] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetch('https://localhost:7013/wizards')
            .then(response => {
                if (response.ok) {
                    return response.json()
                }
                throw response;
            })
            .then(data => {
                console.log(data);
                setData(data);
            })
            .catch(error => {
                console.error("Error fetching data: ", error);
                setError(error);
            })
            .finally(() => {
                setLoading(false);
            })
    }, [])

    if (loading) return "Loading...";
    if (error) return "Error!";

    return (
        <div className="App">
            <header className="App-header">
                <img src={logo} className="App-logo" alt="logo" />
            </header>
            {
                data.map(i => {
                    return (
                        <>
                            <div>{i.id}</div>
                            <div>{i.name}</div>
                            <div>{i.universe}</div>
                            <div>{i.imageUrl}</div>
                        </>
                        
                    )
                })
            }
        </div>
    );
}

export default App;
