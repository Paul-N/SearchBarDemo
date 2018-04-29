//
//  ViewController.swift
//  SearchBarDemo
//
//  Created by Admin on 26.04.2018.
//  Copyright © 2018 Admin. All rights reserved.
//

import UIKit

class ViewController: UITableViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        let search = UISearchController(searchResultsController: UIViewController())
        
            search.dimsBackgroundDuringPresentation = false
        
        //search.SearchResultsUpdater = this;
        // ensures the segue works in the context of the underling ViewController, thanks @artemkalinovsky
        definesPresentationContext = true
        
        //NavigationItem.SearchController = search;
        navigationItem.titleView = search.searchBar;
    }
}

