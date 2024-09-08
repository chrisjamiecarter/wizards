import './App.css';
import React, { useState, useEffect } from 'react';

function App() {

    const [data, setData] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        fetch('https://localhost:7013/wizards/get')
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

    if (loading) return <div className="loading">Loading Data...</div>;
    if (error) return <div className="error">Error Loading Data! {error.message}</div>;

    return (
        <div className="main">
            <div className="wizard-container">
                {
                    data.map(wizard => {
                        return (
                            <div className="wizard-card" key={wizard.id}>
                                <h2 className="wizard-name">{wizard.name}</h2>
                                <img src={wizard.imageUrl} alt={wizard.name} className="wizard-image" />
                                <p className="wizard-description">{wizard.description}</p>
                            </div>
                        )
                    })
                }
            </div>
        </div>
    );
}

export default App;
